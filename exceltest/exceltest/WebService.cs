using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace exceltest
{
    public class wslist : List<WebService>
    {
        public wslist(DataTable inf)
        {
            if (inf != null && inf.Rows.Count != 0)
            {
                this.Clear();
                int index = 0;
                foreach (DataRow ws in inf.Rows)
                {
                    if (!string.IsNullOrEmpty(ws["F22"].ToString()) && index >= 2)
                        this.Add(new WebService()
                        {
                            Availablity = Convert.ToDecimal(ws["F2"]),
                            Throghput = Convert.ToDecimal(ws["F4"]),
                            Reliablity = Convert.ToDecimal(ws["F6"]),
                            Latency = Convert.ToDecimal(ws["F8"]),
                            Privacy = Convert.ToDecimal(ws["F10"]),
                            Longitude = Convert.ToDecimal(ws["F11"]),
                            Latitude = Convert.ToDecimal(ws["F12"]),
                            Price = Convert.ToDecimal(ws["F16"]),
                            SMS = ws["F17"].ToString() == "1",
                            EMail = ws["F18"].ToString() == "1",
                            IM = ws["F19"].ToString() == "1",
                            Device = Convert.ToDecimal(ws["F20"]),
                            WebServiceName = ws["F22"].ToString(),
                            Keyword = inf.Columns.Contains("F23") ? ws["F23"].ToString() : ""
                        });
                    index++;
                }
            }
        }

        /// <summary>
        /// محاسبه امتیاز وب سرویس ها
        /// </summary>
        /// <param name="a">availablity</param>
        /// <param name="t">throghput</param>
        /// <param name="r">reliablity</param>
        /// <param name="l">latency</param>
        /// <param name="p">privacy</param>
        /// <param name="rt">response time</param>
        /// <param name="price">قیمت</param>
        /// <param name="lot">طول جغرافیایی</param>
        /// <param name="lat">عرض جغرافیایی</param>
        public void Calculate(decimal a, decimal t, decimal r, decimal l
            , decimal p, decimal rt, decimal price, bool sms, bool email, bool im, decimal lot, decimal lat)
        {
            if (this.Count != 0)
            {
                this.ForEach(ws => ws.Calculate(a, t, r, l, p, rt, price, sms, email, im, lot, lat));
            }
        }
    }


    public class WebService
    {
        /// <summary>
        /// در دسترس بودن
        /// </summary>
        public decimal Availablity { get; set; }
        /// <summary>
        /// توان عملیاتی
        /// </summary>
        public decimal Throghput { get; set; }
        /// <summary>
        /// قابلیت اطمینان
        /// </summary>
        public decimal Reliablity { get; set; }
        /// <summary>
        /// تاخیر
        /// </summary>
        public decimal Latency { get; set; }
        /// <summary>
        /// امنیت
        /// </summary>
        public decimal Privacy { get; set; }
        /// <summary>
        /// زمان پاسخگویی
        /// </summary>
        public decimal ResponseTime { get; set; }
        /// <summary>
        /// طول جغرافیایی
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// عرض جغرافیایی
        /// </summary>
        public decimal Latitude { get; set; }
        /// <summary>
        /// قیمت
        /// </summary>
        public decimal Price { get; set; }
        public bool SMS { get; set; }
        public bool EMail { get; set; }
        public bool IM { get; set; }
        /// <summary>
        /// امتیاز دستگاه
        /// </summary>
        public decimal Device { get; set; }
        /// <summary>
        /// نام وب سرویس
        /// </summary>
        public string WebServiceName { get; set; }
        /// <summary>
        /// امتیاز بدست آمده
        /// </summary>
        public decimal Point { get; set; }
        /// <summary>
        /// فاصله محاسبه شده تا محل کاربر
        /// </summary>
        public decimal Distanse { get; set; }
        public string Keyword { get; set; }
        /// <summary>
        /// محاسبه امتیاز وب سرویس
        /// </summary>
        /// <param name="a">availablity</param>
        /// <param name="t">throghput</param>
        /// <param name="r">reliablity</param>
        /// <param name="l">latency</param>
        /// <param name="p">privacy</param>
        /// <param name="rt">response time</param>
        /// <param name="price">قیمت</param>
        /// <param name="lot">طول جغرافیایی</param>
        /// <param name="lat">عرض جغرافیایی</param>
        public void Calculate(decimal a, decimal t, decimal r, decimal l
            , decimal p, decimal rt, decimal price, bool sms, bool email, bool im, decimal lot, decimal lat)
        {
            decimal d = (decimal)((sms ? 0.33 : 0) + (email ? 0.33 : 0) + (im ? 0.34 : 0));
            this.Point =
                (a * Availablity) +
                (t * Throghput) +
                (r * Reliablity) +
                (l * Latency) +
                (p * Privacy) +
                (price * Price) +
                (d * Device);
            this.Point = (Availablity != 0) ? Point : 0;
            double c = 0;
            c = 2 *
                Math.Asin(
                    Math.Sqrt(
                        Math.Pow(Math.Sin((double)((Latitude - lat) / 2)), 2) +
                        Math.Cos((double)lat) *
                        Math.Cos((double)Latitude) *
                        Math.Pow(Math.Sin((double)((Longitude - lot) / 2)), 2)
                             )
                         );
            if (c >= 1)
                this.Distanse = (decimal)(6371 * c);
            else
                this.Distanse = (decimal)(6371 * 2 * Math.Asin(1));
        }
    }
}

﻿using AppStudio.DataProviders.Core;

namespace AppStudio.DataProviders.Bing
{
    public class BingDataConfig
    {
        public BingCountry Country { get; set; }

        public string Query { get; set; }
    }

    public enum BingCountry
    {
        [StringValue("ae")]UnitedArabEmirates,
        [StringValue("al")]Albania,
        [StringValue("am")]Armenia,
        [StringValue("ar")]Argentina,
        [StringValue("at")]Austria,
        [StringValue("au")]Australia,
        [StringValue("az")]Azerbaijan,
        [StringValue("ba")]BosniaHerzegovina,
        [StringValue("be")]Belgium,
        [StringValue("bg")]Bulgaria,
        [StringValue("bh")]Bahrain,
        [StringValue("bo")]Bolivia,
        [StringValue("br")]Brazil,
        [StringValue("ca")]Canada,
        [StringValue("ch")]Switzerland,
        [StringValue("cl")]Chile,
        [StringValue("cn")]China,
        [StringValue("cr")]CostaRica,
        [StringValue("de")]Germany,
        [StringValue("do")]DominicanRepublic,
        [StringValue("ec")]Ecuador,
        [StringValue("fr")]France,
        [StringValue("uk")]UnitedKingdom,
        [StringValue("ge")]Georgia,
        [StringValue("gr")]Greece,
        [StringValue("gt")]Guatemala,
        [StringValue("hk")]HongKong,
        [StringValue("hn")]Honduras,
        [StringValue("hr")]Croatia,
        [StringValue("hu")]Hungary,
        [StringValue("id")]Indonesia,
        [StringValue("ie")]Ireland,
        [StringValue("i")]Israel,
        [StringValue("in")]India,
        [StringValue("iq")]Iraq,
        [StringValue("ir")]Iran,
        [StringValue("is")]Iceland,
        [StringValue("it")]Italy,
        [StringValue("jo")]Jordan,
        [StringValue("jp")]Japan,
        [StringValue("ke")]Kenya,
        [StringValue("kr")]Korea,
        [StringValue("kw")]Kuwait,
        [StringValue("lb")]Lebanon,
        [StringValue("lt")]Lithuania,
        [StringValue("lv")]Latvia,
        [StringValue("lu")]Luxembourg,
        [StringValue("ly")]Libya,
        [StringValue("ma")]Morocco,
        [StringValue("mk")]Macedonia,
        [StringValue("mt")]Malta,
        [StringValue("my")]Malaysia,
        [StringValue("mx")]Mexico,
        [StringValue("ni")]Nicaragua,
        [StringValue("nl")]Netherlands,
        [StringValue("nz")]NewZealand,
        [StringValue("no")]Norway,
        [StringValue("om")]Oman,
        [StringValue("pa")]Panama,
        [StringValue("pe")]Peru,
        [StringValue("ph")]Philippines,
        [StringValue("pl")]Poland,
        [StringValue("pk")]Pakistan,
        [StringValue("pr")]PuertoRico,
        [StringValue("ru")]Portugal,
        [StringValue("py")]Paraguay,
        [StringValue("qa")]Qatar,
        [StringValue("ro")]Romania,
        [StringValue("ru")]Russia,
        [StringValue("se")]Sweden,
        [StringValue("sa")]SaudiArabia,
        [StringValue("sg")]Singapore,
        [StringValue("sk")]Slovakia,
        [StringValue("sl")]Slovenia,
        [StringValue("es")]Spain,
        [StringValue("sp")]Serbia,
        [StringValue("sv")]ElSalvador,
        [StringValue("sy")]Syria,
        [StringValue("tw")]Taiwan,
        [StringValue("th")]Thailand,
        [StringValue("tn")]Tunisia,
        [StringValue("tr")]Turkey,
        [StringValue("ua")]Ukraine,
        [StringValue("us")]UnitedStates,
        [StringValue("vn")]Vietnam,
        [StringValue("ye")]Yemen,
        [StringValue("za")]SouthAfrica,
    }
}
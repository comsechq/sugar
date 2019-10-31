﻿using System;
using System.ComponentModel;
using System.Linq;

namespace Sugar.Extensions
{
    /// <summary>
    /// Extension methods to help dealing with ISO 3166 alpha-2 and alpha-3 country codes.
    /// </summary>
    public static class CountryCodeExtensions
    {
        /// <summary>
        /// Converts an ISO 3166 alpha-2 country code to its alpha-3 counter part.
        /// </summary>
        /// <param name="alpha2">The two letter country code.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CountryCode3 ToAlpha3(this CountryCode alpha2)
        {
            switch (alpha2)
            {
                case CountryCode.AD: return CountryCode3.AND;
                case CountryCode.AE: return CountryCode3.ARE;
                case CountryCode.AF: return CountryCode3.AFG;
                case CountryCode.AG: return CountryCode3.ATG;
                case CountryCode.AI: return CountryCode3.AIA;
                case CountryCode.AL: return CountryCode3.ALB;
                case CountryCode.AM: return CountryCode3.ARM;
                case CountryCode.AN: return CountryCode3.ANT;
                case CountryCode.AO: return CountryCode3.AGO;
                case CountryCode.AQ: return CountryCode3.ATA;
                case CountryCode.AR: return CountryCode3.ARG;
                case CountryCode.AS: return CountryCode3.ASM;
                case CountryCode.AT: return CountryCode3.AUT;
                case CountryCode.AU: return CountryCode3.AUS;
                case CountryCode.AW: return CountryCode3.ABW;
                case CountryCode.AX: return CountryCode3.ALA;
                case CountryCode.AZ: return CountryCode3.AZE;
                case CountryCode.BA: return CountryCode3.BIH;
                case CountryCode.BB: return CountryCode3.BRB;
                case CountryCode.BD: return CountryCode3.BGD;
                case CountryCode.BE: return CountryCode3.BEL;
                case CountryCode.BF: return CountryCode3.BFA;
                case CountryCode.BG: return CountryCode3.BGR;
                case CountryCode.BH: return CountryCode3.BHR;
                case CountryCode.BI: return CountryCode3.BDI;
                case CountryCode.BJ: return CountryCode3.BEN;
                case CountryCode.BM: return CountryCode3.BMU;
                case CountryCode.BN: return CountryCode3.BRN;
                case CountryCode.BO: return CountryCode3.BOL;
                case CountryCode.BR: return CountryCode3.BRA;
                case CountryCode.BS: return CountryCode3.BHS;
                case CountryCode.BT: return CountryCode3.BTN;
                case CountryCode.BV: return CountryCode3.BVT;
                case CountryCode.BW: return CountryCode3.BWA;
                case CountryCode.BY: return CountryCode3.BLR;
                case CountryCode.BZ: return CountryCode3.BLZ;
                case CountryCode.CA: return CountryCode3.CAN;
                case CountryCode.CC: return CountryCode3.CCK;
                case CountryCode.CD: return CountryCode3.COD;
                case CountryCode.CF: return CountryCode3.CAF;
                case CountryCode.CG: return CountryCode3.COG;
                case CountryCode.CH: return CountryCode3.CHE;
                case CountryCode.CI: return CountryCode3.CIV;
                case CountryCode.CK: return CountryCode3.COK;
                case CountryCode.CL: return CountryCode3.CHL;
                case CountryCode.CM: return CountryCode3.CMR;
                case CountryCode.CN: return CountryCode3.CHN;
                case CountryCode.CO: return CountryCode3.COL;
                case CountryCode.CR: return CountryCode3.CRI;
                case CountryCode.CU: return CountryCode3.CUB;
                case CountryCode.CV: return CountryCode3.CPV;
                case CountryCode.CX: return CountryCode3.CXR;
                case CountryCode.CY: return CountryCode3.CYP;
                case CountryCode.CZ: return CountryCode3.CZE;
                case CountryCode.DE: return CountryCode3.DEU;
                case CountryCode.DJ: return CountryCode3.DJI;
                case CountryCode.DK: return CountryCode3.DNK;
                case CountryCode.DM: return CountryCode3.DMA;
                case CountryCode.DO: return CountryCode3.DOM;
                case CountryCode.DZ: return CountryCode3.DZA;
                case CountryCode.EC: return CountryCode3.ECU;
                case CountryCode.EE: return CountryCode3.EST;
                case CountryCode.EG: return CountryCode3.EGY;
                case CountryCode.EH: return CountryCode3.ESH;
                case CountryCode.ER: return CountryCode3.ERI;
                case CountryCode.ES: return CountryCode3.ESP;
                case CountryCode.ET: return CountryCode3.ETH;
                case CountryCode.FI: return CountryCode3.FIN;
                case CountryCode.FJ: return CountryCode3.FJI;
                case CountryCode.FK: return CountryCode3.FLK;
                case CountryCode.FM: return CountryCode3.FSM;
                case CountryCode.FO: return CountryCode3.FRO;
                case CountryCode.FR: return CountryCode3.FRA;
                case CountryCode.GA: return CountryCode3.GAB;
                case CountryCode.GB: return CountryCode3.GBR;
                case CountryCode.GD: return CountryCode3.GRD;
                case CountryCode.GE: return CountryCode3.GEO;
                case CountryCode.GF: return CountryCode3.GUF;
                case CountryCode.GH: return CountryCode3.GHA;
                case CountryCode.GI: return CountryCode3.GIB;
                case CountryCode.GL: return CountryCode3.GRL;
                case CountryCode.GM: return CountryCode3.GMB;
                case CountryCode.GN: return CountryCode3.GIN;
                case CountryCode.GP: return CountryCode3.GLP;
                case CountryCode.GQ: return CountryCode3.GNQ;
                case CountryCode.GR: return CountryCode3.GRC;
                case CountryCode.GS: return CountryCode3.SGS;
                case CountryCode.GT: return CountryCode3.GTM;
                case CountryCode.GU: return CountryCode3.GUM;
                case CountryCode.GW: return CountryCode3.GNB;
                case CountryCode.GY: return CountryCode3.GUY;
                case CountryCode.HK: return CountryCode3.HKG;
                case CountryCode.HM: return CountryCode3.HMD;
                case CountryCode.HN: return CountryCode3.HND;
                case CountryCode.HR: return CountryCode3.HRV;
                case CountryCode.HT: return CountryCode3.HTI;
                case CountryCode.HU: return CountryCode3.HUN;
                case CountryCode.ID: return CountryCode3.IDN;
                case CountryCode.IE: return CountryCode3.IRL;
                case CountryCode.IL: return CountryCode3.ISR;
                case CountryCode.IN: return CountryCode3.IND;
                case CountryCode.IO: return CountryCode3.IOT;
                case CountryCode.IQ: return CountryCode3.IRQ;
                case CountryCode.IR: return CountryCode3.IRN;
                case CountryCode.IS: return CountryCode3.ISL;
                case CountryCode.IT: return CountryCode3.ITA;
                case CountryCode.JM: return CountryCode3.JAM;
                case CountryCode.JO: return CountryCode3.JOR;
                case CountryCode.JP: return CountryCode3.JPN;
                case CountryCode.KE: return CountryCode3.KEN;
                case CountryCode.KG: return CountryCode3.KGZ;
                case CountryCode.KH: return CountryCode3.KHM;
                case CountryCode.KI: return CountryCode3.KIR;
                case CountryCode.KM: return CountryCode3.COM;
                case CountryCode.KN: return CountryCode3.KNA;
                case CountryCode.KP: return CountryCode3.PRK;
                case CountryCode.KR: return CountryCode3.KOR;
                case CountryCode.KW: return CountryCode3.KWT;
                case CountryCode.KY: return CountryCode3.CYM;
                case CountryCode.KZ: return CountryCode3.KAZ;
                case CountryCode.LA: return CountryCode3.LAO;
                case CountryCode.LB: return CountryCode3.LBN;
                case CountryCode.LC: return CountryCode3.LCA;
                case CountryCode.LI: return CountryCode3.LIE;
                case CountryCode.LK: return CountryCode3.LKA;
                case CountryCode.LR: return CountryCode3.LBR;
                case CountryCode.LS: return CountryCode3.LSO;
                case CountryCode.LT: return CountryCode3.LTU;
                case CountryCode.LU: return CountryCode3.LUX;
                case CountryCode.LV: return CountryCode3.LVA;
                case CountryCode.LY: return CountryCode3.LBY;
                case CountryCode.MA: return CountryCode3.MAR;
                case CountryCode.MC: return CountryCode3.MCO;
                case CountryCode.MD: return CountryCode3.MDA;
                case CountryCode.MG: return CountryCode3.MDG;
                case CountryCode.MH: return CountryCode3.MHL;
                case CountryCode.MK: return CountryCode3.MKD;
                case CountryCode.ML: return CountryCode3.MLI;
                case CountryCode.MM: return CountryCode3.MMR;
                case CountryCode.MN: return CountryCode3.MNG;
                case CountryCode.MO: return CountryCode3.MAC;
                case CountryCode.MP: return CountryCode3.MNP;
                case CountryCode.MQ: return CountryCode3.MTQ;
                case CountryCode.MR: return CountryCode3.MRT;
                case CountryCode.MS: return CountryCode3.MSR;
                case CountryCode.MT: return CountryCode3.MLT;
                case CountryCode.MU: return CountryCode3.MUS;
                case CountryCode.MV: return CountryCode3.MDV;
                case CountryCode.MW: return CountryCode3.MWI;
                case CountryCode.MX: return CountryCode3.MEX;
                case CountryCode.MY: return CountryCode3.MYS;
                case CountryCode.MZ: return CountryCode3.MOZ;
                case CountryCode.NA: return CountryCode3.NAM;
                case CountryCode.NC: return CountryCode3.NCL;
                case CountryCode.NE: return CountryCode3.NER;
                case CountryCode.NF: return CountryCode3.NFK;
                case CountryCode.NG: return CountryCode3.NGA;
                case CountryCode.NI: return CountryCode3.NIC;
                case CountryCode.NL: return CountryCode3.NLD;
                case CountryCode.NO: return CountryCode3.NOR;
                case CountryCode.NP: return CountryCode3.NPL;
                case CountryCode.NR: return CountryCode3.NRU;
                case CountryCode.NU: return CountryCode3.NIU;
                case CountryCode.NZ: return CountryCode3.NZL;
                case CountryCode.OM: return CountryCode3.OMN;
                case CountryCode.PA: return CountryCode3.PAN;
                case CountryCode.PE: return CountryCode3.PER;
                case CountryCode.PF: return CountryCode3.PYF;
                case CountryCode.PG: return CountryCode3.PNG;
                case CountryCode.PH: return CountryCode3.PHL;
                case CountryCode.PK: return CountryCode3.PAK;
                case CountryCode.PL: return CountryCode3.POL;
                case CountryCode.PM: return CountryCode3.SPM;
                case CountryCode.PN: return CountryCode3.PCN;
                case CountryCode.PR: return CountryCode3.PRI;
                case CountryCode.PS: return CountryCode3.PSE;
                case CountryCode.PT: return CountryCode3.PRT;
                case CountryCode.PW: return CountryCode3.PLW;
                case CountryCode.PY: return CountryCode3.PRY;
                case CountryCode.QA: return CountryCode3.QAT;
                case CountryCode.RE: return CountryCode3.REU;
                case CountryCode.RO: return CountryCode3.ROU;
                case CountryCode.RU: return CountryCode3.RUS;
                case CountryCode.RW: return CountryCode3.RWA;
                case CountryCode.SA: return CountryCode3.SAU;
                case CountryCode.SB: return CountryCode3.SLB;
                case CountryCode.SC: return CountryCode3.SYC;
                case CountryCode.SD: return CountryCode3.SDN;
                case CountryCode.SE: return CountryCode3.SWE;
                case CountryCode.SG: return CountryCode3.SGP;
                case CountryCode.SH: return CountryCode3.SHN;
                case CountryCode.SI: return CountryCode3.SVN;
                case CountryCode.SJ: return CountryCode3.SJM;
                case CountryCode.SK: return CountryCode3.SVK;
                case CountryCode.SL: return CountryCode3.SLE;
                case CountryCode.SM: return CountryCode3.SMR;
                case CountryCode.SN: return CountryCode3.SEN;
                case CountryCode.SO: return CountryCode3.SOM;
                case CountryCode.SR: return CountryCode3.SUR;
                case CountryCode.ST: return CountryCode3.STP;
                case CountryCode.SV: return CountryCode3.SLV;
                case CountryCode.SY: return CountryCode3.SYR;
                case CountryCode.SZ: return CountryCode3.SWZ;
                case CountryCode.TC: return CountryCode3.TCA;
                case CountryCode.TD: return CountryCode3.TCD;
                case CountryCode.TF: return CountryCode3.ATF;
                case CountryCode.TG: return CountryCode3.TGO;
                case CountryCode.TH: return CountryCode3.THA;
                case CountryCode.TJ: return CountryCode3.TJK;
                case CountryCode.TK: return CountryCode3.TKL;
                case CountryCode.TL: return CountryCode3.TLS;
                case CountryCode.TM: return CountryCode3.TKM;
                case CountryCode.TN: return CountryCode3.TUN;
                case CountryCode.TO: return CountryCode3.TON;
                case CountryCode.TR: return CountryCode3.TUR;
                case CountryCode.TT: return CountryCode3.TTO;
                case CountryCode.TV: return CountryCode3.TUV;
                case CountryCode.TW: return CountryCode3.TWN;
                case CountryCode.TZ: return CountryCode3.TZA;
                case CountryCode.UA: return CountryCode3.UKR;
                case CountryCode.UG: return CountryCode3.UGA;
                case CountryCode.UM: return CountryCode3.UMI;
                case CountryCode.US: return CountryCode3.USA;
                case CountryCode.UY: return CountryCode3.URY;
                case CountryCode.UZ: return CountryCode3.UZB;
                case CountryCode.VA: return CountryCode3.VAT;
                case CountryCode.VC: return CountryCode3.VCT;
                case CountryCode.VE: return CountryCode3.VEN;
                case CountryCode.VG: return CountryCode3.VGB;
                case CountryCode.VI: return CountryCode3.VIR;
                case CountryCode.VN: return CountryCode3.VNM;
                case CountryCode.VU: return CountryCode3.VUT;
                case CountryCode.WF: return CountryCode3.WLF;
                case CountryCode.WS: return CountryCode3.WSM;
                case CountryCode.YE: return CountryCode3.YEM;
                case CountryCode.YT: return CountryCode3.MYT;
                case CountryCode.ZA: return CountryCode3.ZAF;
                case CountryCode.ZM: return CountryCode3.ZMB;
                case CountryCode.ZW: return CountryCode3.ZWE;
                default:
                    throw new ArgumentOutOfRangeException(nameof(alpha2), alpha2, "Unknown country code");
            }
        }

        /// <summary>
        /// Converts an ISO 3166 alpha-3 country code to its alpha-2 counter part.
        /// </summary>
        /// <param name="alpha3">The three letter country code.</param>
        /// <returns></returns>

        public static CountryCode ToAlpha2(this CountryCode3 alpha3)
        {
            switch (alpha3)
            {
                case CountryCode3.AND: return CountryCode.AD;
                case CountryCode3.ARE: return CountryCode.AE;
                case CountryCode3.AFG: return CountryCode.AF;
                case CountryCode3.ATG: return CountryCode.AG;
                case CountryCode3.AIA: return CountryCode.AI;
                case CountryCode3.ALB: return CountryCode.AL;
                case CountryCode3.ARM: return CountryCode.AM;
                case CountryCode3.ANT: return CountryCode.AN;
                case CountryCode3.AGO: return CountryCode.AO;
                case CountryCode3.ATA: return CountryCode.AQ;
                case CountryCode3.ARG: return CountryCode.AR;
                case CountryCode3.ASM: return CountryCode.AS;
                case CountryCode3.AUT: return CountryCode.AT;
                case CountryCode3.AUS: return CountryCode.AU;
                case CountryCode3.ABW: return CountryCode.AW;
                case CountryCode3.ALA: return CountryCode.AX;
                case CountryCode3.AZE: return CountryCode.AZ;
                case CountryCode3.BIH: return CountryCode.BA;
                case CountryCode3.BRB: return CountryCode.BB;
                case CountryCode3.BGD: return CountryCode.BD;
                case CountryCode3.BEL: return CountryCode.BE;
                case CountryCode3.BFA: return CountryCode.BF;
                case CountryCode3.BGR: return CountryCode.BG;
                case CountryCode3.BHR: return CountryCode.BH;
                case CountryCode3.BDI: return CountryCode.BI;
                case CountryCode3.BEN: return CountryCode.BJ;
                case CountryCode3.BMU: return CountryCode.BM;
                case CountryCode3.BRN: return CountryCode.BN;
                case CountryCode3.BOL: return CountryCode.BO;
                case CountryCode3.BRA: return CountryCode.BR;
                case CountryCode3.BHS: return CountryCode.BS;
                case CountryCode3.BTN: return CountryCode.BT;
                case CountryCode3.BVT: return CountryCode.BV;
                case CountryCode3.BWA: return CountryCode.BW;
                case CountryCode3.BLR: return CountryCode.BY;
                case CountryCode3.BLZ: return CountryCode.BZ;
                case CountryCode3.CAN: return CountryCode.CA;
                case CountryCode3.CCK: return CountryCode.CC;
                case CountryCode3.COD: return CountryCode.CD;
                case CountryCode3.CAF: return CountryCode.CF;
                case CountryCode3.COG: return CountryCode.CG;
                case CountryCode3.CHE: return CountryCode.CH;
                case CountryCode3.CIV: return CountryCode.CI;
                case CountryCode3.COK: return CountryCode.CK;
                case CountryCode3.CHL: return CountryCode.CL;
                case CountryCode3.CMR: return CountryCode.CM;
                case CountryCode3.CHN: return CountryCode.CN;
                case CountryCode3.COL: return CountryCode.CO;
                case CountryCode3.CRI: return CountryCode.CR;
                case CountryCode3.CUB: return CountryCode.CU;
                case CountryCode3.CPV: return CountryCode.CV;
                case CountryCode3.CXR: return CountryCode.CX;
                case CountryCode3.CYP: return CountryCode.CY;
                case CountryCode3.CZE: return CountryCode.CZ;
                case CountryCode3.DEU: return CountryCode.DE;
                case CountryCode3.DJI: return CountryCode.DJ;
                case CountryCode3.DNK: return CountryCode.DK;
                case CountryCode3.DMA: return CountryCode.DM;
                case CountryCode3.DOM: return CountryCode.DO;
                case CountryCode3.DZA: return CountryCode.DZ;
                case CountryCode3.ECU: return CountryCode.EC;
                case CountryCode3.EST: return CountryCode.EE;
                case CountryCode3.EGY: return CountryCode.EG;
                case CountryCode3.ESH: return CountryCode.EH;
                case CountryCode3.ERI: return CountryCode.ER;
                case CountryCode3.ESP: return CountryCode.ES;
                case CountryCode3.ETH: return CountryCode.ET;
                case CountryCode3.FIN: return CountryCode.FI;
                case CountryCode3.FJI: return CountryCode.FJ;
                case CountryCode3.FLK: return CountryCode.FK;
                case CountryCode3.FSM: return CountryCode.FM;
                case CountryCode3.FRO: return CountryCode.FO;
                case CountryCode3.FRA: return CountryCode.FR;
                case CountryCode3.GAB: return CountryCode.GA;
                case CountryCode3.GBR: return CountryCode.GB;
                case CountryCode3.GRD: return CountryCode.GD;
                case CountryCode3.GEO: return CountryCode.GE;
                case CountryCode3.GUF: return CountryCode.GF;
                case CountryCode3.GHA: return CountryCode.GH;
                case CountryCode3.GIB: return CountryCode.GI;
                case CountryCode3.GRL: return CountryCode.GL;
                case CountryCode3.GMB: return CountryCode.GM;
                case CountryCode3.GIN: return CountryCode.GN;
                case CountryCode3.GLP: return CountryCode.GP;
                case CountryCode3.GNQ: return CountryCode.GQ;
                case CountryCode3.GRC: return CountryCode.GR;
                case CountryCode3.SGS: return CountryCode.GS;
                case CountryCode3.GTM: return CountryCode.GT;
                case CountryCode3.GUM: return CountryCode.GU;
                case CountryCode3.GNB: return CountryCode.GW;
                case CountryCode3.GUY: return CountryCode.GY;
                case CountryCode3.HKG: return CountryCode.HK;
                case CountryCode3.HMD: return CountryCode.HM;
                case CountryCode3.HND: return CountryCode.HN;
                case CountryCode3.HRV: return CountryCode.HR;
                case CountryCode3.HTI: return CountryCode.HT;
                case CountryCode3.HUN: return CountryCode.HU;
                case CountryCode3.IDN: return CountryCode.ID;
                case CountryCode3.IRL: return CountryCode.IE;
                case CountryCode3.ISR: return CountryCode.IL;
                case CountryCode3.IND: return CountryCode.IN;
                case CountryCode3.IOT: return CountryCode.IO;
                case CountryCode3.IRQ: return CountryCode.IQ;
                case CountryCode3.IRN: return CountryCode.IR;
                case CountryCode3.ISL: return CountryCode.IS;
                case CountryCode3.ITA: return CountryCode.IT;
                case CountryCode3.JAM: return CountryCode.JM;
                case CountryCode3.JOR: return CountryCode.JO;
                case CountryCode3.JPN: return CountryCode.JP;
                case CountryCode3.KEN: return CountryCode.KE;
                case CountryCode3.KGZ: return CountryCode.KG;
                case CountryCode3.KHM: return CountryCode.KH;
                case CountryCode3.KIR: return CountryCode.KI;
                case CountryCode3.COM: return CountryCode.KM;
                case CountryCode3.KNA: return CountryCode.KN;
                case CountryCode3.PRK: return CountryCode.KP;
                case CountryCode3.KOR: return CountryCode.KR;
                case CountryCode3.KWT: return CountryCode.KW;
                case CountryCode3.CYM: return CountryCode.KY;
                case CountryCode3.KAZ: return CountryCode.KZ;
                case CountryCode3.LAO: return CountryCode.LA;
                case CountryCode3.LBN: return CountryCode.LB;
                case CountryCode3.LCA: return CountryCode.LC;
                case CountryCode3.LIE: return CountryCode.LI;
                case CountryCode3.LKA: return CountryCode.LK;
                case CountryCode3.LBR: return CountryCode.LR;
                case CountryCode3.LSO: return CountryCode.LS;
                case CountryCode3.LTU: return CountryCode.LT;
                case CountryCode3.LUX: return CountryCode.LU;
                case CountryCode3.LVA: return CountryCode.LV;
                case CountryCode3.LBY: return CountryCode.LY;
                case CountryCode3.MAR: return CountryCode.MA;
                case CountryCode3.MCO: return CountryCode.MC;
                case CountryCode3.MDA: return CountryCode.MD;
                case CountryCode3.MDG: return CountryCode.MG;
                case CountryCode3.MHL: return CountryCode.MH;
                case CountryCode3.MKD: return CountryCode.MK;
                case CountryCode3.MLI: return CountryCode.ML;
                case CountryCode3.MMR: return CountryCode.MM;
                case CountryCode3.MNG: return CountryCode.MN;
                case CountryCode3.MAC: return CountryCode.MO;
                case CountryCode3.MNP: return CountryCode.MP;
                case CountryCode3.MTQ: return CountryCode.MQ;
                case CountryCode3.MRT: return CountryCode.MR;
                case CountryCode3.MSR: return CountryCode.MS;
                case CountryCode3.MLT: return CountryCode.MT;
                case CountryCode3.MUS: return CountryCode.MU;
                case CountryCode3.MDV: return CountryCode.MV;
                case CountryCode3.MWI: return CountryCode.MW;
                case CountryCode3.MEX: return CountryCode.MX;
                case CountryCode3.MYS: return CountryCode.MY;
                case CountryCode3.MOZ: return CountryCode.MZ;
                case CountryCode3.NAM: return CountryCode.NA;
                case CountryCode3.NCL: return CountryCode.NC;
                case CountryCode3.NER: return CountryCode.NE;
                case CountryCode3.NFK: return CountryCode.NF;
                case CountryCode3.NGA: return CountryCode.NG;
                case CountryCode3.NIC: return CountryCode.NI;
                case CountryCode3.NLD: return CountryCode.NL;
                case CountryCode3.NOR: return CountryCode.NO;
                case CountryCode3.NPL: return CountryCode.NP;
                case CountryCode3.NRU: return CountryCode.NR;
                case CountryCode3.NIU: return CountryCode.NU;
                case CountryCode3.NZL: return CountryCode.NZ;
                case CountryCode3.OMN: return CountryCode.OM;
                case CountryCode3.PAN: return CountryCode.PA;
                case CountryCode3.PER: return CountryCode.PE;
                case CountryCode3.PYF: return CountryCode.PF;
                case CountryCode3.PNG: return CountryCode.PG;
                case CountryCode3.PHL: return CountryCode.PH;
                case CountryCode3.PAK: return CountryCode.PK;
                case CountryCode3.POL: return CountryCode.PL;
                case CountryCode3.SPM: return CountryCode.PM;
                case CountryCode3.PCN: return CountryCode.PN;
                case CountryCode3.PRI: return CountryCode.PR;
                case CountryCode3.PSE: return CountryCode.PS;
                case CountryCode3.PRT: return CountryCode.PT;
                case CountryCode3.PLW: return CountryCode.PW;
                case CountryCode3.PRY: return CountryCode.PY;
                case CountryCode3.QAT: return CountryCode.QA;
                case CountryCode3.REU: return CountryCode.RE;
                case CountryCode3.ROU: return CountryCode.RO;
                case CountryCode3.RUS: return CountryCode.RU;
                case CountryCode3.RWA: return CountryCode.RW;
                case CountryCode3.SAU: return CountryCode.SA;
                case CountryCode3.SLB: return CountryCode.SB;
                case CountryCode3.SYC: return CountryCode.SC;
                case CountryCode3.SDN: return CountryCode.SD;
                case CountryCode3.SWE: return CountryCode.SE;
                case CountryCode3.SGP: return CountryCode.SG;
                case CountryCode3.SHN: return CountryCode.SH;
                case CountryCode3.SVN: return CountryCode.SI;
                case CountryCode3.SJM: return CountryCode.SJ;
                case CountryCode3.SVK: return CountryCode.SK;
                case CountryCode3.SLE: return CountryCode.SL;
                case CountryCode3.SMR: return CountryCode.SM;
                case CountryCode3.SEN: return CountryCode.SN;
                case CountryCode3.SOM: return CountryCode.SO;
                case CountryCode3.SUR: return CountryCode.SR;
                case CountryCode3.STP: return CountryCode.ST;
                case CountryCode3.SLV: return CountryCode.SV;
                case CountryCode3.SYR: return CountryCode.SY;
                case CountryCode3.SWZ: return CountryCode.SZ;
                case CountryCode3.TCA: return CountryCode.TC;
                case CountryCode3.TCD: return CountryCode.TD;
                case CountryCode3.ATF: return CountryCode.TF;
                case CountryCode3.TGO: return CountryCode.TG;
                case CountryCode3.THA: return CountryCode.TH;
                case CountryCode3.TJK: return CountryCode.TJ;
                case CountryCode3.TKL: return CountryCode.TK;
                case CountryCode3.TLS: return CountryCode.TL;
                case CountryCode3.TKM: return CountryCode.TM;
                case CountryCode3.TUN: return CountryCode.TN;
                case CountryCode3.TON: return CountryCode.TO;
                case CountryCode3.TUR: return CountryCode.TR;
                case CountryCode3.TTO: return CountryCode.TT;
                case CountryCode3.TUV: return CountryCode.TV;
                case CountryCode3.TWN: return CountryCode.TW;
                case CountryCode3.TZA: return CountryCode.TZ;
                case CountryCode3.UKR: return CountryCode.UA;
                case CountryCode3.UGA: return CountryCode.UG;
                case CountryCode3.UMI: return CountryCode.UM;
                case CountryCode3.USA: return CountryCode.US;
                case CountryCode3.URY: return CountryCode.UY;
                case CountryCode3.UZB: return CountryCode.UZ;
                case CountryCode3.VAT: return CountryCode.VA;
                case CountryCode3.VCT: return CountryCode.VC;
                case CountryCode3.VEN: return CountryCode.VE;
                case CountryCode3.VGB: return CountryCode.VG;
                case CountryCode3.VIR: return CountryCode.VI;
                case CountryCode3.VNM: return CountryCode.VN;
                case CountryCode3.VUT: return CountryCode.VU;
                case CountryCode3.WLF: return CountryCode.WF;
                case CountryCode3.WSM: return CountryCode.WS;
                case CountryCode3.YEM: return CountryCode.YE;
                case CountryCode3.MYT: return CountryCode.YT;
                case CountryCode3.ZAF: return CountryCode.ZA;
                case CountryCode3.ZMB: return CountryCode.ZM;
                case CountryCode3.ZWE: return CountryCode.ZW;
                default:
                    throw new ArgumentOutOfRangeException(nameof(alpha3), alpha3, "Unknown country code");
            }
        }

        /// <summary>
        /// Countries the name to country code.
        /// </summary>
        /// <param name="countryName">Name of the country.</param>
        /// <returns></returns>
        public static CountryCode? CountryNameToCountryCode(string countryName)
        {
            var countryCodes = Enum.GetValues(typeof(CountryCode)).Cast<CountryCode>();
            foreach (var countryCode in countryCodes)
            {
                if (countryCode.GetAttribute<DescriptionAttribute>().Description == countryName)
                {
                    return countryCode;
                }
            }

            return null;
        }
    }
}
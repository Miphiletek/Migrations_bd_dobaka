namespace Migrations_bd
{
    public class gar_houses
    {
        public long id { get; set; }

        public long OBJECTID { get; set; }

        public string OBJECTGUID { get; set; }

        public long CHANGEID { get; set; }

        public string HOUSENUM { get; set; }

        public string ADDNUM1 { get; set; }

        public string ADDNUM2 { get; set; }

        public string HOUSETYPE { get; set; }

        public string ADDTYPE1 { get; set; }

        public string ADDTYPE2 { get; set; }

        public string OPERTYPEID { get; set; }

        public long PREVID { get; set; }

        public long NEXTID { get; set; }

        public System.DateTime UPDATEDATE { get; set; }

        public System.DateTime STARTDATE { get; set; }

        public System.DateTime ENDDATE { get; set; }

        public HOUSESHOUSEISACTUAL ISACTUAL { get; set; }

        public HOUSESHOUSEISACTIVE ISACTIVE { get; set; }
    }
}

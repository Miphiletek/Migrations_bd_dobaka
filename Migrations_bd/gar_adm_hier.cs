namespace Migrations_bd
{
    public class gar_adm_hier
    {
        public long id { get; set; }

        public long OBJECTID { get; set; }

        public long PARENTOBJID { get; set; }

        public long CHANGEID { get; set; }

        public string REGIONCODE { get; set; }

        public string AREACODE { get; set; }

        public string CITYCODE { get; set; }

        public string PLACECODE { get; set; }

        public string PLANCODE { get; set; }

        public string STREETCODE { get; set; }

        public long PREVID { get; set; }

        public long NEXTID { get; set; }

        public System.DateTime UPDATEDATE { get; set; }

        public System.DateTime STARTDATE { get; set; }

        public System.DateTime ENDDATE { get; set; }

        public ITEMSITEMISACTIVE ISACTIVE { get; set; }
    }
}

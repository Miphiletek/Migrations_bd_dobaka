namespace Migrations_bd
{
    public class gar_address_objects
    {
        public long ID { get; set; }

        public long OBJECTID { get; set; }

        public string OBJECTGUID { get; set; }

        public long CHANGEID { get; set; }

        public string NAME { get; set; }

        public string TYPENAME { get; set; }

        public string LEVEL { get; set; }

        public string OPERTYPEID { get; set; }

        public long PREVID { get; set; }

        public long NEXTID { get; set; }

        public System.DateTime UPDATEDATE { get; set; }

        public System.DateTime STARTDATE { get; set; }

        public System.DateTime ENDDATE { get; set; }

        public ADDRESSOBJECTSOBJECTISACTUAL ISACTUAL { get; set; }

        public ADDRESSOBJECTSOBJECTISACTIVE ISACTIVE { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Migrations_bd
{

    public class FromHouseXML
    {
        ///// <summary>
        ///// objectId в xml дома
        ///// </summary>
        public List<int> HouseId { get; set; }
        public List<Guid> HouseGuid { get; set; }
        public List<string> HouseNUM { get; set; }
    }

    public class FromADDRXML
    {
        public List<Guid> AOGUID { get; set; }
        /// <summary>
        /// objectId в xml улицы
        /// </summary>
        public List<int> ADDRId { get; set; }

    }

    public class FromADMINHIERXML
    {
        /// <summary>
        /// parentId в xml администрации обозначающий улицу
        /// </summary>
        public List<int> ParentId { get; set; }
        /// <summary>
        /// objectId в xml администрации обозначающий дом
        /// </summary>
        public List<int> House_HouseId { get; set; }

    }
}

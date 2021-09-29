using System.Collections.Generic;
using System.Xml;


namespace Migrations_bd
{
    public class PereKid
    {

        IEnumerable<List<ITEMSITEM>> ReadFiles()
        {
            string connection = "C:/Users/Dmitry/Desktop/AS_ADM_HIER.XML";
            using (var reader = XmlReader.Create(connection))
            {
                var files = new List<ITEMSITEM>();

                while (reader.ReadToFollowing(""))
                {
                    var file = new ITEMSITEM();
                    file.PARENTOBJID = reader.ReadElementContentAsLong();

                    reader.MoveToContent();
                    file.OBJECTID = reader.ReadElementContentAsLong();

                    reader.MoveToContent();


                    files.Add(file);

                    if (files.Count % 50000 == 0)
                    {
                        yield return files;
                        files = new List<ITEMSITEM>();
                    }
                }

                if (files.Count > 0)
                    yield return files;
            }
        }
    }

}

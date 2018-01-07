using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entity
{
    public class Subject
    {
        private string id;
        private string subjectName;

        public Subject(string id, string name)
        {
            this.Id = id;
            this.SubjectName = name;
        }

        public Subject()
        {

        }
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public void SubjectIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            SubjectName = dr["subjectName"] is DBNull ? string.Empty : dr["subjectName"].ToString();
        }
        public string SubjectName
        {
            get
            {
                return subjectName;
            }

            set
            {
                subjectName = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class QuizDAL:SqlDataProvider
    {
        public List<Quiz> Quiz_GetByTop(string Top, string Where, string Order)
        {
            List<Quiz> list = new List<Quiz>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Quiz_getByTop", openConnection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                dr.Close();
                dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       Quiz obj = new Quiz();
                        obj.QuizIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }

        public int Quiz_Insert(Quiz data)
        {
            int id = -1;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Quiz_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@subjectID", data.SubjectID));
                    dbCmd.Parameters.Add(new SqlParameter("@quizName", data.QuizName));
                    dbCmd.Parameters.Add(new SqlParameter("@qCountSingle", data.QCountSingle));
                    dbCmd.Parameters.Add(new SqlParameter("@qCountMultiple", data.QCountMultiple));
                    dbCmd.Parameters.Add(new SqlParameter("@time", data.Time));
                    dbCmd.Parameters.Add(new SqlParameter("@teacherID", data.TeacherID));
                    dbCmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    dbCmd.ExecuteNonQuery();
                    id = int.Parse(dbCmd.Parameters["@id"].Value.ToString());
                }
            }
            catch
            {
            }
            return id;
        }
        public bool Quiz_Update(Quiz data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Quiz_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", data.Id));
                    dbCmd.Parameters.Add(new SqlParameter("@subjectID", data.SubjectID));
                    dbCmd.Parameters.Add(new SqlParameter("@quizName", data.QuizName));
                    dbCmd.Parameters.Add(new SqlParameter("@qCountSingle", data.QCountSingle));
                    dbCmd.Parameters.Add(new SqlParameter("@qCountMultiple", data.QCountMultiple));
                    dbCmd.Parameters.Add(new SqlParameter("@time", data.Time));
                    dbCmd.Parameters.Add(new SqlParameter("@teacherID", data.TeacherID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
        public bool Quiz_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Quiz_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EFDemoDb")))
            {
             var output = connection.Query<Person>("dbo.GetByLastNames @LastName", new {LastName = lastName}).ToList();
                return output;
            }
         }

        public void InsertPerson(string firstName, string lastName, string emailAdress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EFDemoDb")))
            {
                Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAdress};

                List<Person> people = new List<Person>();
                people.Add(newPerson);

                connection.Execute("dbo.People_Insert @FirstName,@LastName, @EmailAddress", people);

            }
            }
    }
}

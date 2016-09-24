using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserEF.DAL;
using UserEF.Models;

namespace UserEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new IwContext())
            {


                //context.Users.Add(new Models.User() { FirstName = "eita 6", LastName = "porra 6", Address1 = "address 6", Address2 = "Address 2 6" });
                //context.Users.Add(new Models.User() { FirstName = "eita 7", LastName = "porra 7", Address1 = "Address 7", Address2 = "Address 2 7" });
                //context.SaveChanges();


                //context.CustomFields.Add(new CustomField() { Name = "cf1", Type = CustomFieldType.Text  });
                //context.CustomFields.Add(new CustomField() { Name = "cf2", Type = CustomFieldType.Lookup });
                //context.SaveChanges();

                Models.User u = context.Users.Where(x => x.UserId == 6).FirstOrDefault();
                u.CustomFieldValues.Add(new TextCustomField() { CustomFieldId = 100, Value = "test 2" });
                u.CustomFieldValues.Add(new LookupCustomField() { CustomFieldId = 101, LookupValue = 200 });
                context.SaveChanges();

                //Models.User u = context.Users.Where(x => x.UserId == 2).FirstOrDefault();
                //var cf100 = u.CustomFieldValues.Where(f => f.CustomFieldId == 100).FirstOrDefault();
                //((TextCustomField)cf100).Value = "testc update";

                //var cf101 = u.CustomFieldValues.Where(f => f.CustomFieldId == 101).FirstOrDefault();
                //((LookupCustomField)cf101).LookupValue = -1;
                //context.SaveChanges();

            }
        }
    }
}

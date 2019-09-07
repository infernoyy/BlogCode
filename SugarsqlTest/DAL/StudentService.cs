using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using Model;

namespace DAL
{
    public class StudentService
    {
        SqlSugarClient db = new SqlSugarClient(
            new ConnectionConfig()
            {
                ConnectionString = "server=DESKTOP-K4V0MM7;uid=sa;pwd=123456;database=SugarsqlTest",
                DbType = DbType.SqlServer,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });


        public List<Student> SelectAll()
        {
            return db.Queryable<Student>().ToList();
        }
        
        public bool Insert()
        {
            /*插入*/
            var data = new Student() {
                Name = "E",
                Age = "5",
                Sex = "Man"
            };
            db.Insertable(data).InsertColumns(it => new { it.Name, it.Age, it.Sex }).ExecuteReturnIdentity();
            //更多插入用法 http://www.codeisbug.com/Doc/8/1130
            return true;
        }
        public bool Update()
        {
            /*更新*/
            var data2 = new Student()
            {
                //ID = 5,
                Name = "E",
                Age = "6",
                Sex = "Woman"
            };
            db.Updateable(data2).WhereColumns(it => new { it.Name }).IgnoreColumns(it => it == "ID").ExecuteCommand();
            //db.Updateable(data2).UpdateColumns(it => new { it.Age, it.Sex }).WhereColumns(it => new { it.ID });
            //更多更新用法 http://www.codeisbug.com/Doc/8/1129

            return true;
        }
        public bool Delete()
        {
            /*删除*/
            db.Deleteable<Student>().In(it => it.Name, new string[] { "E" }).ExecuteCommand();
            //更多删除用法 http://www.codeisbug.com/Doc/8/1128
            return true;
        }
    }
}

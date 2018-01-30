using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //users
    public partial class users
    {

        public bool Exists(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from users");
            strSql.Append(" where ");
            strSql.Append(" user_name = @user_name and  ");
            strSql.Append(" password = @password and  ");
            strSql.Append(" user_type = @user_type and  ");
            strSql.Append(" departid = @departid and  ");
            strSql.Append(" indate = @indate and  ");
            strSql.Append(" grade = @grade and  ");
            strSql.Append(" statue = @statue and  ");
            strSql.Append(" user_title = @user_title and  ");
            strSql.Append(" pwh = @pwh and  ");
            strSql.Append(" capacity = @capacity and  ");
            strSql.Append(" isedit = @isedit and  ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" pasword = @pasword and  ");
            strSql.Append(" bz = @bz and  ");
            strSql.Append(" islogin = @islogin  ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,30),
					new SqlParameter("@user_type", SqlDbType.NVarChar,10),
					new SqlParameter("@departid", SqlDbType.NVarChar,20),
					new SqlParameter("@indate", SqlDbType.DateTime),
					new SqlParameter("@grade", SqlDbType.Int,4),
					new SqlParameter("@statue", SqlDbType.Bit,1),
					new SqlParameter("@user_title", SqlDbType.NVarChar,20),
					new SqlParameter("@pwh", SqlDbType.NVarChar,10),
					new SqlParameter("@capacity", SqlDbType.NVarChar,-1),
					new SqlParameter("@isedit", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pasword", SqlDbType.NVarChar,30),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@islogin", SqlDbType.Bit,1)			};
            parameters[0].Value = user_name;
            parameters[1].Value = password;
            parameters[2].Value = user_type;
            parameters[3].Value = departid;
            parameters[4].Value = indate;
            parameters[5].Value = grade;
            parameters[6].Value = statue;
            parameters[7].Value = user_title;
            parameters[8].Value = pwh;
            parameters[9].Value = capacity;
            parameters[10].Value = isedit;
            parameters[11].Value = id;
            parameters[12].Value = pasword;
            parameters[13].Value = bz;
            parameters[14].Value = islogin;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Maticsoft.Model.users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into users(");
            strSql.Append("user_name,capacity,isedit,id,pasword,bz,islogin,password,user_type,departid,indate,grade,statue,user_title,pwh");
            strSql.Append(") values (");
            strSql.Append("@user_name,@capacity,@isedit,@id,@pasword,@bz,@islogin,@password,@user_type,@departid,@indate,@grade,@statue,@user_title,@pwh");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@user_name", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@capacity", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@isedit", SqlDbType.Bit,1) ,            
                        new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@pasword", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@bz", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@islogin", SqlDbType.Bit,1) ,            
                        new SqlParameter("@password", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@user_type", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@departid", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@indate", SqlDbType.DateTime) ,            
                        new SqlParameter("@grade", SqlDbType.Int,4) ,            
                        new SqlParameter("@statue", SqlDbType.Bit,1) ,            
                        new SqlParameter("@user_title", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@pwh", SqlDbType.NVarChar,10)             
              
            };

            parameters[0].Value = model.user_name;
            parameters[1].Value = model.capacity;
            parameters[2].Value = model.isedit;
            parameters[3].Value = model.id;
            parameters[4].Value = model.pasword;
            parameters[5].Value = model.bz;
            parameters[6].Value = model.islogin;
            parameters[7].Value = model.password;
            parameters[8].Value = model.user_type;
            parameters[9].Value = model.departid;
            parameters[10].Value = model.indate;
            parameters[11].Value = model.grade;
            parameters[12].Value = model.statue;
            parameters[13].Value = model.user_title;
            parameters[14].Value = model.pwh;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update users set ");

            strSql.Append(" user_name = @user_name , ");
            strSql.Append(" capacity = @capacity , ");
            strSql.Append(" isedit = @isedit , ");
            strSql.Append(" id = @id , ");
            strSql.Append(" pasword = @pasword , ");
            strSql.Append(" bz = @bz , ");
            strSql.Append(" islogin = @islogin , ");
            strSql.Append(" password = @password , ");
            strSql.Append(" user_type = @user_type , ");
            strSql.Append(" departid = @departid , ");
            strSql.Append(" indate = @indate , ");
            strSql.Append(" grade = @grade , ");
            strSql.Append(" statue = @statue , ");
            strSql.Append(" user_title = @user_title , ");
            strSql.Append(" pwh = @pwh  ");
            strSql.Append(" where user_name=@user_name and password=@password and user_type=@user_type and departid=@departid and indate=@indate and grade=@grade and statue=@statue and user_title=@user_title and pwh=@pwh and capacity=@capacity and isedit=@isedit and id=@id and pasword=@pasword and bz=@bz and islogin=@islogin  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@user_name", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@capacity", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@isedit", SqlDbType.Bit,1) ,            
                        new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@pasword", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@bz", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@islogin", SqlDbType.Bit,1) ,            
                        new SqlParameter("@password", SqlDbType.NVarChar,30) ,            
                        new SqlParameter("@user_type", SqlDbType.NVarChar,10) ,            
                        new SqlParameter("@departid", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@indate", SqlDbType.DateTime) ,            
                        new SqlParameter("@grade", SqlDbType.Int,4) ,            
                        new SqlParameter("@statue", SqlDbType.Bit,1) ,            
                        new SqlParameter("@user_title", SqlDbType.NVarChar,20) ,            
                        new SqlParameter("@pwh", SqlDbType.NVarChar,10)             
              
            };

            parameters[0].Value = model.user_name;
            parameters[1].Value = model.capacity;
            parameters[2].Value = model.isedit;
            parameters[3].Value = model.id;
            parameters[4].Value = model.pasword;
            parameters[5].Value = model.bz;
            parameters[6].Value = model.islogin;
            parameters[7].Value = model.password;
            parameters[8].Value = model.user_type;
            parameters[9].Value = model.departid;
            parameters[10].Value = model.indate;
            parameters[11].Value = model.grade;
            parameters[12].Value = model.statue;
            parameters[13].Value = model.user_title;
            parameters[14].Value = model.pwh;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from users ");
            strSql.Append(" where user_name=@user_name and password=@password and user_type=@user_type and departid=@departid and indate=@indate and grade=@grade and statue=@statue and user_title=@user_title and pwh=@pwh and capacity=@capacity and isedit=@isedit and id=@id and pasword=@pasword and bz=@bz and islogin=@islogin ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,30),
					new SqlParameter("@user_type", SqlDbType.NVarChar,10),
					new SqlParameter("@departid", SqlDbType.NVarChar,20),
					new SqlParameter("@indate", SqlDbType.DateTime),
					new SqlParameter("@grade", SqlDbType.Int,4),
					new SqlParameter("@statue", SqlDbType.Bit,1),
					new SqlParameter("@user_title", SqlDbType.NVarChar,20),
					new SqlParameter("@pwh", SqlDbType.NVarChar,10),
					new SqlParameter("@capacity", SqlDbType.NVarChar,-1),
					new SqlParameter("@isedit", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pasword", SqlDbType.NVarChar,30),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@islogin", SqlDbType.Bit,1)			};
            parameters[0].Value = user_name;
            parameters[1].Value = password;
            parameters[2].Value = user_type;
            parameters[3].Value = departid;
            parameters[4].Value = indate;
            parameters[5].Value = grade;
            parameters[6].Value = statue;
            parameters[7].Value = user_title;
            parameters[8].Value = pwh;
            parameters[9].Value = capacity;
            parameters[10].Value = isedit;
            parameters[11].Value = id;
            parameters[12].Value = pasword;
            parameters[13].Value = bz;
            parameters[14].Value = islogin;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.users GetModel(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select user_name, capacity, isedit, id, pasword, bz, islogin, password, user_type, departid, indate, grade, statue, user_title, pwh  ");
            strSql.Append("  from users ");
            strSql.Append(" where user_name=@user_name and password=@password and user_type=@user_type and departid=@departid and indate=@indate and grade=@grade and statue=@statue and user_title=@user_title and pwh=@pwh and capacity=@capacity and isedit=@isedit and id=@id and pasword=@pasword and bz=@bz and islogin=@islogin ");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,30),
					new SqlParameter("@password", SqlDbType.NVarChar,30),
					new SqlParameter("@user_type", SqlDbType.NVarChar,10),
					new SqlParameter("@departid", SqlDbType.NVarChar,20),
					new SqlParameter("@indate", SqlDbType.DateTime),
					new SqlParameter("@grade", SqlDbType.Int,4),
					new SqlParameter("@statue", SqlDbType.Bit,1),
					new SqlParameter("@user_title", SqlDbType.NVarChar,20),
					new SqlParameter("@pwh", SqlDbType.NVarChar,10),
					new SqlParameter("@capacity", SqlDbType.NVarChar,-1),
					new SqlParameter("@isedit", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@pasword", SqlDbType.NVarChar,30),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@islogin", SqlDbType.Bit,1)			};
            parameters[0].Value = user_name;
            parameters[1].Value = password;
            parameters[2].Value = user_type;
            parameters[3].Value = departid;
            parameters[4].Value = indate;
            parameters[5].Value = grade;
            parameters[6].Value = statue;
            parameters[7].Value = user_title;
            parameters[8].Value = pwh;
            parameters[9].Value = capacity;
            parameters[10].Value = isedit;
            parameters[11].Value = id;
            parameters[12].Value = pasword;
            parameters[13].Value = bz;
            parameters[14].Value = islogin;


            Maticsoft.Model.users model = new Maticsoft.Model.users();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.user_name = ds.Tables[0].Rows[0]["user_name"].ToString();
                model.capacity = ds.Tables[0].Rows[0]["capacity"].ToString();
                if (ds.Tables[0].Rows[0]["isedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["isedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["isedit"].ToString().ToLower() == "true"))
                    {
                        model.isedit = true;
                    }
                    else
                    {
                        model.isedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.pasword = ds.Tables[0].Rows[0]["pasword"].ToString();
                model.bz = ds.Tables[0].Rows[0]["bz"].ToString();
                if (ds.Tables[0].Rows[0]["islogin"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["islogin"].ToString() == "1") || (ds.Tables[0].Rows[0]["islogin"].ToString().ToLower() == "true"))
                    {
                        model.islogin = true;
                    }
                    else
                    {
                        model.islogin = false;
                    }
                }
                model.password = ds.Tables[0].Rows[0]["password"].ToString();
                model.user_type = ds.Tables[0].Rows[0]["user_type"].ToString();
                model.departid = ds.Tables[0].Rows[0]["departid"].ToString();
                if (ds.Tables[0].Rows[0]["indate"].ToString() != "")
                {
                    model.indate = DateTime.Parse(ds.Tables[0].Rows[0]["indate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["grade"].ToString() != "")
                {
                    model.grade = int.Parse(ds.Tables[0].Rows[0]["grade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["statue"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["statue"].ToString() == "1") || (ds.Tables[0].Rows[0]["statue"].ToString().ToLower() == "true"))
                    {
                        model.statue = true;
                    }
                    else
                    {
                        model.statue = false;
                    }
                }
                model.user_title = ds.Tables[0].Rows[0]["user_title"].ToString();
                model.pwh = ds.Tables[0].Rows[0]["pwh"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}


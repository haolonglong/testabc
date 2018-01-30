using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    //users
    public partial class users
    {

        private readonly Maticsoft.DAL.users dal = new Maticsoft.DAL.users();
        public users()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {
            return dal.Exists(user_name, password, user_type, departid, indate, grade, statue, user_title, pwh, capacity, isedit, id, pasword, bz, islogin);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Maticsoft.Model.users model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.users model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {

            return dal.Delete(user_name, password, user_type, departid, indate, grade, statue, user_title, pwh, capacity, isedit, id, pasword, bz, islogin);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.users GetModel(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {

            return dal.GetModel(user_name, password, user_type, departid, indate, grade, statue, user_title, pwh, capacity, isedit, id, pasword, bz, islogin);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Maticsoft.Model.users GetModelByCache(string user_name, string password, string user_type, string departid, DateTime indate, int grade, bool statue, string user_title, string pwh, string capacity, bool isedit, int id, string pasword, string bz, bool islogin)
        {

            string CacheKey = "usersModel-" + user_name + password + user_type + departid + indate + grade + statue + user_title + pwh + capacity + isedit + id + pasword + bz + islogin;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(user_name, password, user_type, departid, indate, grade, statue, user_title, pwh, capacity, isedit, id, pasword, bz, islogin);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Maticsoft.Model.users)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.users> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.users> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.users> modelList = new List<Maticsoft.Model.users>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.users model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Maticsoft.Model.users();
                    model.user_name = dt.Rows[n]["user_name"].ToString();
                    model.capacity = dt.Rows[n]["capacity"].ToString();
                    if (dt.Rows[n]["isedit"].ToString() != "")
                    {
                        if ((dt.Rows[n]["isedit"].ToString() == "1") || (dt.Rows[n]["isedit"].ToString().ToLower() == "true"))
                        {
                            model.isedit = true;
                        }
                        else
                        {
                            model.isedit = false;
                        }
                    }
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.pasword = dt.Rows[n]["pasword"].ToString();
                    model.bz = dt.Rows[n]["bz"].ToString();
                    if (dt.Rows[n]["islogin"].ToString() != "")
                    {
                        if ((dt.Rows[n]["islogin"].ToString() == "1") || (dt.Rows[n]["islogin"].ToString().ToLower() == "true"))
                        {
                            model.islogin = true;
                        }
                        else
                        {
                            model.islogin = false;
                        }
                    }
                    model.password = dt.Rows[n]["password"].ToString();
                    model.user_type = dt.Rows[n]["user_type"].ToString();
                    model.departid = dt.Rows[n]["departid"].ToString();
                    if (dt.Rows[n]["indate"].ToString() != "")
                    {
                        model.indate = DateTime.Parse(dt.Rows[n]["indate"].ToString());
                    }
                    if (dt.Rows[n]["grade"].ToString() != "")
                    {
                        model.grade = int.Parse(dt.Rows[n]["grade"].ToString());
                    }
                    if (dt.Rows[n]["statue"].ToString() != "")
                    {
                        if ((dt.Rows[n]["statue"].ToString() == "1") || (dt.Rows[n]["statue"].ToString().ToLower() == "true"))
                        {
                            model.statue = true;
                        }
                        else
                        {
                            model.statue = false;
                        }
                    }
                    model.user_title = dt.Rows[n]["user_title"].ToString();
                    model.pwh = dt.Rows[n]["pwh"].ToString();


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

    }
}
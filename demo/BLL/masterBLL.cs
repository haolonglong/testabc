using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
    /// <summary>
    /// master
    /// </summary>
    public partial class master
    {
        private readonly Maticsoft.DAL.master dal = new Maticsoft.DAL.master();
        public master()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {
            return dal.Exists(ident, ord, depart, name, pinyin, idcode, birthday, sex, education, post_name, post_rank, post_date, grad_date, college, s_major, grad_time, w_date, zg_date, jg_date, w_major, cs_title, cs_date, ds_title, fl_kind, fl_level, fl_grade, fl_year, fl_type, fl_dep, com_type, com_grade, com_passdate, exploit, examine, award, maven1, maven2, pwhmc, pwhrs, cxrs, zcps, fdps, qqps, hbps, shsj, tjbym, zpw, zpsj, cpyj, pg, dwmc, dwdm, bz, shenhe, pingshen, jl, cplw, com_dep, sk_dep, com_level, com_modeln, sk_year, sk_kind, sk_grade, sk_level, sk_list, zsqk, year, zylb);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.master model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.master model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {

            return dal.Delete(ident, ord, depart, name, pinyin, idcode, birthday, sex, education, post_name, post_rank, post_date, grad_date, college, s_major, grad_time, w_date, zg_date, jg_date, w_major, cs_title, cs_date, ds_title, fl_kind, fl_level, fl_grade, fl_year, fl_type, fl_dep, com_type, com_grade, com_passdate, exploit, examine, award, maven1, maven2, pwhmc, pwhrs, cxrs, zcps, fdps, qqps, hbps, shsj, tjbym, zpw, zpsj, cpyj, pg, dwmc, dwdm, bz, shenhe, pingshen, jl, cplw, com_dep, sk_dep, com_level, com_modeln, sk_year, sk_kind, sk_grade, sk_level, sk_list, zsqk, year, zylb);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.master GetModel(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {

            return dal.GetModel(ident, ord, depart, name, pinyin, idcode, birthday, sex, education, post_name, post_rank, post_date, grad_date, college, s_major, grad_time, w_date, zg_date, jg_date, w_major, cs_title, cs_date, ds_title, fl_kind, fl_level, fl_grade, fl_year, fl_type, fl_dep, com_type, com_grade, com_passdate, exploit, examine, award, maven1, maven2, pwhmc, pwhrs, cxrs, zcps, fdps, qqps, hbps, shsj, tjbym, zpw, zpsj, cpyj, pg, dwmc, dwdm, bz, shenhe, pingshen, jl, cplw, com_dep, sk_dep, com_level, com_modeln, sk_year, sk_kind, sk_grade, sk_level, sk_list, zsqk, year, zylb);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Maticsoft.Model.master GetModelByCache(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {

            string CacheKey = "masterModel-" + ident + ord + depart + name + pinyin + idcode + birthday + sex + education + post_name + post_rank + post_date + grad_date + college + s_major + grad_time + w_date + zg_date + jg_date + w_major + cs_title + cs_date + ds_title + fl_kind + fl_level + fl_grade + fl_year + fl_type + fl_dep + com_type + com_grade + com_passdate + exploit + examine + award + maven1 + maven2 + pwhmc + pwhrs + cxrs + zcps + fdps + qqps + hbps + shsj + tjbym + zpw + zpsj + cpyj + pg + dwmc + dwdm + bz + shenhe + pingshen + jl + cplw + com_dep + sk_dep + com_level + com_modeln + sk_year + sk_kind + sk_grade + sk_level + sk_list + zsqk + year + zylb;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ident, ord, depart, name, pinyin, idcode, birthday, sex, education, post_name, post_rank, post_date, grad_date, college, s_major, grad_time, w_date, zg_date, jg_date, w_major, cs_title, cs_date, ds_title, fl_kind, fl_level, fl_grade, fl_year, fl_type, fl_dep, com_type, com_grade, com_passdate, exploit, examine, award, maven1, maven2, pwhmc, pwhrs, cxrs, zcps, fdps, qqps, hbps, shsj, tjbym, zpw, zpsj, cpyj, pg, dwmc, dwdm, bz, shenhe, pingshen, jl, cplw, com_dep, sk_dep, com_level, com_modeln, sk_year, sk_kind, sk_grade, sk_level, sk_list, zsqk, year, zylb);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Maticsoft.Model.master)objModel;
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
        public List<Maticsoft.Model.master> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Maticsoft.Model.master> DataTableToList(DataTable dt)
        {
            List<Maticsoft.Model.master> modelList = new List<Maticsoft.Model.master>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Maticsoft.Model.master model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
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

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


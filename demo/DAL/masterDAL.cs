using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references

namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:master
    /// </summary>
    public partial class master
    {
        public master()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from master");
            strSql.Append(" where ident=@ident and ord=@ord and depart=@depart and name=@name and pinyin=@pinyin and idcode=@idcode and birthday=@birthday and sex=@sex and education=@education and post_name=@post_name and post_rank=@post_rank and post_date=@post_date and grad_date=@grad_date and college=@college and s_major=@s_major and grad_time=@grad_time and w_date=@w_date and zg_date=@zg_date and jg_date=@jg_date and w_major=@w_major and cs_title=@cs_title and cs_date=@cs_date and ds_title=@ds_title and fl_kind=@fl_kind and fl_level=@fl_level and fl_grade=@fl_grade and fl_year=@fl_year and fl_type=@fl_type and fl_dep=@fl_dep and com_type=@com_type and com_grade=@com_grade and com_passdate=@com_passdate and exploit=@exploit and examine=@examine and award=@award and maven1=@maven1 and maven2=@maven2 and pwhmc=@pwhmc and pwhrs=@pwhrs and cxrs=@cxrs and zcps=@zcps and fdps=@fdps and qqps=@qqps and hbps=@hbps and shsj=@shsj and tjbym=@tjbym and zpw=@zpw and zpsj=@zpsj and cpyj=@cpyj and pg=@pg and dwmc=@dwmc and dwdm=@dwdm and bz=@bz and shenhe=@shenhe and pingshen=@pingshen and jl=@jl and cplw=@cplw and com_dep=@com_dep and sk_dep=@sk_dep and com_level=@com_level and com_modeln=@com_modeln and sk_year=@sk_year and sk_kind=@sk_kind and sk_grade=@sk_grade and sk_level=@sk_level and sk_list=@sk_list and zsqk=@zsqk and year=@year and zylb=@zylb ");
            SqlParameter[] parameters = {
					new SqlParameter("@ident", SqlDbType.NVarChar,25),
					new SqlParameter("@ord", SqlDbType.SmallInt,2),
					new SqlParameter("@depart", SqlDbType.NVarChar,6),
					new SqlParameter("@name", SqlDbType.NVarChar,10),
					new SqlParameter("@pinyin", SqlDbType.NVarChar,5),
					new SqlParameter("@idcode", SqlDbType.NVarChar,18),
					new SqlParameter("@birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,2),
					new SqlParameter("@education", SqlDbType.NVarChar,2),
					new SqlParameter("@post_name", SqlDbType.NVarChar,20),
					new SqlParameter("@post_rank", SqlDbType.NVarChar,12),
					new SqlParameter("@post_date", SqlDbType.NVarChar,6),
					new SqlParameter("@grad_date", SqlDbType.NVarChar,6),
					new SqlParameter("@college", SqlDbType.NVarChar,40),
					new SqlParameter("@s_major", SqlDbType.NVarChar,30),
					new SqlParameter("@grad_time", SqlDbType.NVarChar,3),
					new SqlParameter("@w_date", SqlDbType.NVarChar,6),
					new SqlParameter("@zg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@jg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@w_major", SqlDbType.NVarChar,30),
					new SqlParameter("@cs_title", SqlDbType.NVarChar,4),
					new SqlParameter("@cs_date", SqlDbType.NVarChar,6),
					new SqlParameter("@ds_title", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@fl_level", SqlDbType.NVarChar,1),
					new SqlParameter("@fl_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@fl_year", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_type", SqlDbType.NVarChar,20),
					new SqlParameter("@fl_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_type", SqlDbType.NVarChar,20),
					new SqlParameter("@com_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@com_passdate", SqlDbType.NVarChar,4),
					new SqlParameter("@exploit", SqlDbType.NVarChar,-1),
					new SqlParameter("@examine", SqlDbType.NVarChar,-1),
					new SqlParameter("@award", SqlDbType.NVarChar,-1),
					new SqlParameter("@maven1", SqlDbType.NVarChar,6),
					new SqlParameter("@maven2", SqlDbType.NVarChar,6),
					new SqlParameter("@pwhmc", SqlDbType.NVarChar,40),
					new SqlParameter("@pwhrs", SqlDbType.SmallInt,2),
					new SqlParameter("@cxrs", SqlDbType.SmallInt,2),
					new SqlParameter("@zcps", SqlDbType.SmallInt,2),
					new SqlParameter("@fdps", SqlDbType.SmallInt,2),
					new SqlParameter("@qqps", SqlDbType.SmallInt,2),
					new SqlParameter("@hbps", SqlDbType.SmallInt,2),
					new SqlParameter("@shsj", SqlDbType.NVarChar,8),
					new SqlParameter("@tjbym", SqlDbType.SmallInt,2),
					new SqlParameter("@zpw", SqlDbType.NVarChar,6),
					new SqlParameter("@zpsj", SqlDbType.NVarChar,8),
					new SqlParameter("@cpyj", SqlDbType.NVarChar,100),
					new SqlParameter("@pg", SqlDbType.NVarChar,2),
					new SqlParameter("@dwmc", SqlDbType.NVarChar,40),
					new SqlParameter("@dwdm", SqlDbType.NVarChar,6),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@shenhe", SqlDbType.NVarChar,2),
					new SqlParameter("@pingshen", SqlDbType.NVarChar,6),
					new SqlParameter("@jl", SqlDbType.NVarChar,-1),
					new SqlParameter("@cplw", SqlDbType.NVarChar,100),
					new SqlParameter("@com_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_level", SqlDbType.NVarChar,4),
					new SqlParameter("@com_modeln", SqlDbType.Int,4),
					new SqlParameter("@sk_year", SqlDbType.NVarChar,4),
					new SqlParameter("@sk_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_grade", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_level", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_list", SqlDbType.NVarChar,10),
					new SqlParameter("@zsqk", SqlDbType.NVarChar,50),
					new SqlParameter("@year", SqlDbType.NVarChar,25),
					new SqlParameter("@zylb", SqlDbType.NVarChar,50)			};
            parameters[0].Value = ident;
            parameters[1].Value = ord;
            parameters[2].Value = depart;
            parameters[3].Value = name;
            parameters[4].Value = pinyin;
            parameters[5].Value = idcode;
            parameters[6].Value = birthday;
            parameters[7].Value = sex;
            parameters[8].Value = education;
            parameters[9].Value = post_name;
            parameters[10].Value = post_rank;
            parameters[11].Value = post_date;
            parameters[12].Value = grad_date;
            parameters[13].Value = college;
            parameters[14].Value = s_major;
            parameters[15].Value = grad_time;
            parameters[16].Value = w_date;
            parameters[17].Value = zg_date;
            parameters[18].Value = jg_date;
            parameters[19].Value = w_major;
            parameters[20].Value = cs_title;
            parameters[21].Value = cs_date;
            parameters[22].Value = ds_title;
            parameters[23].Value = fl_kind;
            parameters[24].Value = fl_level;
            parameters[25].Value = fl_grade;
            parameters[26].Value = fl_year;
            parameters[27].Value = fl_type;
            parameters[28].Value = fl_dep;
            parameters[29].Value = com_type;
            parameters[30].Value = com_grade;
            parameters[31].Value = com_passdate;
            parameters[32].Value = exploit;
            parameters[33].Value = examine;
            parameters[34].Value = award;
            parameters[35].Value = maven1;
            parameters[36].Value = maven2;
            parameters[37].Value = pwhmc;
            parameters[38].Value = pwhrs;
            parameters[39].Value = cxrs;
            parameters[40].Value = zcps;
            parameters[41].Value = fdps;
            parameters[42].Value = qqps;
            parameters[43].Value = hbps;
            parameters[44].Value = shsj;
            parameters[45].Value = tjbym;
            parameters[46].Value = zpw;
            parameters[47].Value = zpsj;
            parameters[48].Value = cpyj;
            parameters[49].Value = pg;
            parameters[50].Value = dwmc;
            parameters[51].Value = dwdm;
            parameters[52].Value = bz;
            parameters[53].Value = shenhe;
            parameters[54].Value = pingshen;
            parameters[55].Value = jl;
            parameters[56].Value = cplw;
            parameters[57].Value = com_dep;
            parameters[58].Value = sk_dep;
            parameters[59].Value = com_level;
            parameters[60].Value = com_modeln;
            parameters[61].Value = sk_year;
            parameters[62].Value = sk_kind;
            parameters[63].Value = sk_grade;
            parameters[64].Value = sk_level;
            parameters[65].Value = sk_list;
            parameters[66].Value = zsqk;
            parameters[67].Value = year;
            parameters[68].Value = zylb;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.master model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into master(");
            strSql.Append("ident,ord,depart,name,pinyin,idcode,birthday,sex,education,post_name,post_rank,post_date,grad_date,college,s_major,grad_time,w_date,zg_date,jg_date,w_major,cs_title,cs_date,ds_title,fl_kind,fl_level,fl_grade,fl_year,fl_type,fl_dep,com_type,com_grade,com_passdate,exploit,examine,award,maven1,maven2,pwhmc,pwhrs,cxrs,zcps,fdps,qqps,hbps,shsj,tjbym,zpw,zpsj,cpyj,pg,dwmc,dwdm,bz,shenhe,pingshen,jl,cplw,com_dep,sk_dep,com_level,com_modeln,sk_year,sk_kind,sk_grade,sk_level,sk_list,zsqk,year,zylb)");
            strSql.Append(" values (");
            strSql.Append("@ident,@ord,@depart,@name,@pinyin,@idcode,@birthday,@sex,@education,@post_name,@post_rank,@post_date,@grad_date,@college,@s_major,@grad_time,@w_date,@zg_date,@jg_date,@w_major,@cs_title,@cs_date,@ds_title,@fl_kind,@fl_level,@fl_grade,@fl_year,@fl_type,@fl_dep,@com_type,@com_grade,@com_passdate,@exploit,@examine,@award,@maven1,@maven2,@pwhmc,@pwhrs,@cxrs,@zcps,@fdps,@qqps,@hbps,@shsj,@tjbym,@zpw,@zpsj,@cpyj,@pg,@dwmc,@dwdm,@bz,@shenhe,@pingshen,@jl,@cplw,@com_dep,@sk_dep,@com_level,@com_modeln,@sk_year,@sk_kind,@sk_grade,@sk_level,@sk_list,@zsqk,@year,@zylb)");
            SqlParameter[] parameters = {
					new SqlParameter("@ident", SqlDbType.NVarChar,25),
					new SqlParameter("@ord", SqlDbType.SmallInt,2),
					new SqlParameter("@depart", SqlDbType.NVarChar,6),
					new SqlParameter("@name", SqlDbType.NVarChar,10),
					new SqlParameter("@pinyin", SqlDbType.NVarChar,5),
					new SqlParameter("@idcode", SqlDbType.NVarChar,18),
					new SqlParameter("@birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,2),
					new SqlParameter("@education", SqlDbType.NVarChar,2),
					new SqlParameter("@post_name", SqlDbType.NVarChar,20),
					new SqlParameter("@post_rank", SqlDbType.NVarChar,12),
					new SqlParameter("@post_date", SqlDbType.NVarChar,6),
					new SqlParameter("@grad_date", SqlDbType.NVarChar,6),
					new SqlParameter("@college", SqlDbType.NVarChar,40),
					new SqlParameter("@s_major", SqlDbType.NVarChar,30),
					new SqlParameter("@grad_time", SqlDbType.NVarChar,3),
					new SqlParameter("@w_date", SqlDbType.NVarChar,6),
					new SqlParameter("@zg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@jg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@w_major", SqlDbType.NVarChar,30),
					new SqlParameter("@cs_title", SqlDbType.NVarChar,4),
					new SqlParameter("@cs_date", SqlDbType.NVarChar,6),
					new SqlParameter("@ds_title", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@fl_level", SqlDbType.NVarChar,1),
					new SqlParameter("@fl_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@fl_year", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_type", SqlDbType.NVarChar,20),
					new SqlParameter("@fl_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_type", SqlDbType.NVarChar,20),
					new SqlParameter("@com_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@com_passdate", SqlDbType.NVarChar,4),
					new SqlParameter("@exploit", SqlDbType.NVarChar,-1),
					new SqlParameter("@examine", SqlDbType.NVarChar,-1),
					new SqlParameter("@award", SqlDbType.NVarChar,-1),
					new SqlParameter("@maven1", SqlDbType.NVarChar,6),
					new SqlParameter("@maven2", SqlDbType.NVarChar,6),
					new SqlParameter("@pwhmc", SqlDbType.NVarChar,40),
					new SqlParameter("@pwhrs", SqlDbType.SmallInt,2),
					new SqlParameter("@cxrs", SqlDbType.SmallInt,2),
					new SqlParameter("@zcps", SqlDbType.SmallInt,2),
					new SqlParameter("@fdps", SqlDbType.SmallInt,2),
					new SqlParameter("@qqps", SqlDbType.SmallInt,2),
					new SqlParameter("@hbps", SqlDbType.SmallInt,2),
					new SqlParameter("@shsj", SqlDbType.NVarChar,8),
					new SqlParameter("@tjbym", SqlDbType.SmallInt,2),
					new SqlParameter("@zpw", SqlDbType.NVarChar,6),
					new SqlParameter("@zpsj", SqlDbType.NVarChar,8),
					new SqlParameter("@cpyj", SqlDbType.NVarChar,100),
					new SqlParameter("@pg", SqlDbType.NVarChar,2),
					new SqlParameter("@dwmc", SqlDbType.NVarChar,40),
					new SqlParameter("@dwdm", SqlDbType.NVarChar,6),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@shenhe", SqlDbType.NVarChar,2),
					new SqlParameter("@pingshen", SqlDbType.NVarChar,6),
					new SqlParameter("@jl", SqlDbType.NVarChar,-1),
					new SqlParameter("@cplw", SqlDbType.NVarChar,100),
					new SqlParameter("@com_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_level", SqlDbType.NVarChar,4),
					new SqlParameter("@com_modeln", SqlDbType.Int,4),
					new SqlParameter("@sk_year", SqlDbType.NVarChar,4),
					new SqlParameter("@sk_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_grade", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_level", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_list", SqlDbType.NVarChar,10),
					new SqlParameter("@zsqk", SqlDbType.NVarChar,50),
					new SqlParameter("@year", SqlDbType.NVarChar,25),
					new SqlParameter("@zylb", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.ident;
            parameters[1].Value = model.ord;
            parameters[2].Value = model.depart;
            parameters[3].Value = model.name;
            parameters[4].Value = model.pinyin;
            parameters[5].Value = model.idcode;
            parameters[6].Value = model.birthday;
            parameters[7].Value = model.sex;
            parameters[8].Value = model.education;
            parameters[9].Value = model.post_name;
            parameters[10].Value = model.post_rank;
            parameters[11].Value = model.post_date;
            parameters[12].Value = model.grad_date;
            parameters[13].Value = model.college;
            parameters[14].Value = model.s_major;
            parameters[15].Value = model.grad_time;
            parameters[16].Value = model.w_date;
            parameters[17].Value = model.zg_date;
            parameters[18].Value = model.jg_date;
            parameters[19].Value = model.w_major;
            parameters[20].Value = model.cs_title;
            parameters[21].Value = model.cs_date;
            parameters[22].Value = model.ds_title;
            parameters[23].Value = model.fl_kind;
            parameters[24].Value = model.fl_level;
            parameters[25].Value = model.fl_grade;
            parameters[26].Value = model.fl_year;
            parameters[27].Value = model.fl_type;
            parameters[28].Value = model.fl_dep;
            parameters[29].Value = model.com_type;
            parameters[30].Value = model.com_grade;
            parameters[31].Value = model.com_passdate;
            parameters[32].Value = model.exploit;
            parameters[33].Value = model.examine;
            parameters[34].Value = model.award;
            parameters[35].Value = model.maven1;
            parameters[36].Value = model.maven2;
            parameters[37].Value = model.pwhmc;
            parameters[38].Value = model.pwhrs;
            parameters[39].Value = model.cxrs;
            parameters[40].Value = model.zcps;
            parameters[41].Value = model.fdps;
            parameters[42].Value = model.qqps;
            parameters[43].Value = model.hbps;
            parameters[44].Value = model.shsj;
            parameters[45].Value = model.tjbym;
            parameters[46].Value = model.zpw;
            parameters[47].Value = model.zpsj;
            parameters[48].Value = model.cpyj;
            parameters[49].Value = model.pg;
            parameters[50].Value = model.dwmc;
            parameters[51].Value = model.dwdm;
            parameters[52].Value = model.bz;
            parameters[53].Value = model.shenhe;
            parameters[54].Value = model.pingshen;
            parameters[55].Value = model.jl;
            parameters[56].Value = model.cplw;
            parameters[57].Value = model.com_dep;
            parameters[58].Value = model.sk_dep;
            parameters[59].Value = model.com_level;
            parameters[60].Value = model.com_modeln;
            parameters[61].Value = model.sk_year;
            parameters[62].Value = model.sk_kind;
            parameters[63].Value = model.sk_grade;
            parameters[64].Value = model.sk_level;
            parameters[65].Value = model.sk_list;
            parameters[66].Value = model.zsqk;
            parameters[67].Value = model.year;
            parameters[68].Value = model.zylb;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.master model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update master set ");
            strSql.Append("ident=@ident,");
            strSql.Append("ord=@ord,");
            strSql.Append("depart=@depart,");
            strSql.Append("name=@name,");
            strSql.Append("pinyin=@pinyin,");
            strSql.Append("idcode=@idcode,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("sex=@sex,");
            strSql.Append("education=@education,");
            strSql.Append("post_name=@post_name,");
            strSql.Append("post_rank=@post_rank,");
            strSql.Append("post_date=@post_date,");
            strSql.Append("grad_date=@grad_date,");
            strSql.Append("college=@college,");
            strSql.Append("s_major=@s_major,");
            strSql.Append("grad_time=@grad_time,");
            strSql.Append("w_date=@w_date,");
            strSql.Append("zg_date=@zg_date,");
            strSql.Append("jg_date=@jg_date,");
            strSql.Append("w_major=@w_major,");
            strSql.Append("cs_title=@cs_title,");
            strSql.Append("cs_date=@cs_date,");
            strSql.Append("ds_title=@ds_title,");
            strSql.Append("fl_kind=@fl_kind,");
            strSql.Append("fl_level=@fl_level,");
            strSql.Append("fl_grade=@fl_grade,");
            strSql.Append("fl_year=@fl_year,");
            strSql.Append("fl_type=@fl_type,");
            strSql.Append("fl_dep=@fl_dep,");
            strSql.Append("com_type=@com_type,");
            strSql.Append("com_grade=@com_grade,");
            strSql.Append("com_passdate=@com_passdate,");
            strSql.Append("exploit=@exploit,");
            strSql.Append("examine=@examine,");
            strSql.Append("award=@award,");
            strSql.Append("maven1=@maven1,");
            strSql.Append("maven2=@maven2,");
            strSql.Append("pwhmc=@pwhmc,");
            strSql.Append("pwhrs=@pwhrs,");
            strSql.Append("cxrs=@cxrs,");
            strSql.Append("zcps=@zcps,");
            strSql.Append("fdps=@fdps,");
            strSql.Append("qqps=@qqps,");
            strSql.Append("hbps=@hbps,");
            strSql.Append("shsj=@shsj,");
            strSql.Append("tjbym=@tjbym,");
            strSql.Append("zpw=@zpw,");
            strSql.Append("zpsj=@zpsj,");
            strSql.Append("cpyj=@cpyj,");
            strSql.Append("pg=@pg,");
            strSql.Append("dwmc=@dwmc,");
            strSql.Append("dwdm=@dwdm,");
            strSql.Append("bz=@bz,");
            strSql.Append("shenhe=@shenhe,");
            strSql.Append("pingshen=@pingshen,");
            strSql.Append("jl=@jl,");
            strSql.Append("cplw=@cplw,");
            strSql.Append("com_dep=@com_dep,");
            strSql.Append("sk_dep=@sk_dep,");
            strSql.Append("com_level=@com_level,");
            strSql.Append("com_modeln=@com_modeln,");
            strSql.Append("sk_year=@sk_year,");
            strSql.Append("sk_kind=@sk_kind,");
            strSql.Append("sk_grade=@sk_grade,");
            strSql.Append("sk_level=@sk_level,");
            strSql.Append("sk_list=@sk_list,");
            strSql.Append("zsqk=@zsqk,");
            strSql.Append("year=@year,");
            strSql.Append("zylb=@zylb");
            strSql.Append(" where ident=@ident and ord=@ord and depart=@depart and name=@name and pinyin=@pinyin and idcode=@idcode and birthday=@birthday and sex=@sex and education=@education and post_name=@post_name and post_rank=@post_rank and post_date=@post_date and grad_date=@grad_date and college=@college and s_major=@s_major and grad_time=@grad_time and w_date=@w_date and zg_date=@zg_date and jg_date=@jg_date and w_major=@w_major and cs_title=@cs_title and cs_date=@cs_date and ds_title=@ds_title and fl_kind=@fl_kind and fl_level=@fl_level and fl_grade=@fl_grade and fl_year=@fl_year and fl_type=@fl_type and fl_dep=@fl_dep and com_type=@com_type and com_grade=@com_grade and com_passdate=@com_passdate and exploit=@exploit and examine=@examine and award=@award and maven1=@maven1 and maven2=@maven2 and pwhmc=@pwhmc and pwhrs=@pwhrs and cxrs=@cxrs and zcps=@zcps and fdps=@fdps and qqps=@qqps and hbps=@hbps and shsj=@shsj and tjbym=@tjbym and zpw=@zpw and zpsj=@zpsj and cpyj=@cpyj and pg=@pg and dwmc=@dwmc and dwdm=@dwdm and bz=@bz and shenhe=@shenhe and pingshen=@pingshen and jl=@jl and cplw=@cplw and com_dep=@com_dep and sk_dep=@sk_dep and com_level=@com_level and com_modeln=@com_modeln and sk_year=@sk_year and sk_kind=@sk_kind and sk_grade=@sk_grade and sk_level=@sk_level and sk_list=@sk_list and zsqk=@zsqk and year=@year and zylb=@zylb ");
            SqlParameter[] parameters = {
					new SqlParameter("@ident", SqlDbType.NVarChar,25),
					new SqlParameter("@ord", SqlDbType.SmallInt,2),
					new SqlParameter("@depart", SqlDbType.NVarChar,6),
					new SqlParameter("@name", SqlDbType.NVarChar,10),
					new SqlParameter("@pinyin", SqlDbType.NVarChar,5),
					new SqlParameter("@idcode", SqlDbType.NVarChar,18),
					new SqlParameter("@birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,2),
					new SqlParameter("@education", SqlDbType.NVarChar,2),
					new SqlParameter("@post_name", SqlDbType.NVarChar,20),
					new SqlParameter("@post_rank", SqlDbType.NVarChar,12),
					new SqlParameter("@post_date", SqlDbType.NVarChar,6),
					new SqlParameter("@grad_date", SqlDbType.NVarChar,6),
					new SqlParameter("@college", SqlDbType.NVarChar,40),
					new SqlParameter("@s_major", SqlDbType.NVarChar,30),
					new SqlParameter("@grad_time", SqlDbType.NVarChar,3),
					new SqlParameter("@w_date", SqlDbType.NVarChar,6),
					new SqlParameter("@zg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@jg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@w_major", SqlDbType.NVarChar,30),
					new SqlParameter("@cs_title", SqlDbType.NVarChar,4),
					new SqlParameter("@cs_date", SqlDbType.NVarChar,6),
					new SqlParameter("@ds_title", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@fl_level", SqlDbType.NVarChar,1),
					new SqlParameter("@fl_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@fl_year", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_type", SqlDbType.NVarChar,20),
					new SqlParameter("@fl_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_type", SqlDbType.NVarChar,20),
					new SqlParameter("@com_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@com_passdate", SqlDbType.NVarChar,4),
					new SqlParameter("@exploit", SqlDbType.NVarChar,-1),
					new SqlParameter("@examine", SqlDbType.NVarChar,-1),
					new SqlParameter("@award", SqlDbType.NVarChar,-1),
					new SqlParameter("@maven1", SqlDbType.NVarChar,6),
					new SqlParameter("@maven2", SqlDbType.NVarChar,6),
					new SqlParameter("@pwhmc", SqlDbType.NVarChar,40),
					new SqlParameter("@pwhrs", SqlDbType.SmallInt,2),
					new SqlParameter("@cxrs", SqlDbType.SmallInt,2),
					new SqlParameter("@zcps", SqlDbType.SmallInt,2),
					new SqlParameter("@fdps", SqlDbType.SmallInt,2),
					new SqlParameter("@qqps", SqlDbType.SmallInt,2),
					new SqlParameter("@hbps", SqlDbType.SmallInt,2),
					new SqlParameter("@shsj", SqlDbType.NVarChar,8),
					new SqlParameter("@tjbym", SqlDbType.SmallInt,2),
					new SqlParameter("@zpw", SqlDbType.NVarChar,6),
					new SqlParameter("@zpsj", SqlDbType.NVarChar,8),
					new SqlParameter("@cpyj", SqlDbType.NVarChar,100),
					new SqlParameter("@pg", SqlDbType.NVarChar,2),
					new SqlParameter("@dwmc", SqlDbType.NVarChar,40),
					new SqlParameter("@dwdm", SqlDbType.NVarChar,6),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@shenhe", SqlDbType.NVarChar,2),
					new SqlParameter("@pingshen", SqlDbType.NVarChar,6),
					new SqlParameter("@jl", SqlDbType.NVarChar,-1),
					new SqlParameter("@cplw", SqlDbType.NVarChar,100),
					new SqlParameter("@com_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_level", SqlDbType.NVarChar,4),
					new SqlParameter("@com_modeln", SqlDbType.Int,4),
					new SqlParameter("@sk_year", SqlDbType.NVarChar,4),
					new SqlParameter("@sk_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_grade", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_level", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_list", SqlDbType.NVarChar,10),
					new SqlParameter("@zsqk", SqlDbType.NVarChar,50),
					new SqlParameter("@year", SqlDbType.NVarChar,25),
					new SqlParameter("@zylb", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.ident;
            parameters[1].Value = model.ord;
            parameters[2].Value = model.depart;
            parameters[3].Value = model.name;
            parameters[4].Value = model.pinyin;
            parameters[5].Value = model.idcode;
            parameters[6].Value = model.birthday;
            parameters[7].Value = model.sex;
            parameters[8].Value = model.education;
            parameters[9].Value = model.post_name;
            parameters[10].Value = model.post_rank;
            parameters[11].Value = model.post_date;
            parameters[12].Value = model.grad_date;
            parameters[13].Value = model.college;
            parameters[14].Value = model.s_major;
            parameters[15].Value = model.grad_time;
            parameters[16].Value = model.w_date;
            parameters[17].Value = model.zg_date;
            parameters[18].Value = model.jg_date;
            parameters[19].Value = model.w_major;
            parameters[20].Value = model.cs_title;
            parameters[21].Value = model.cs_date;
            parameters[22].Value = model.ds_title;
            parameters[23].Value = model.fl_kind;
            parameters[24].Value = model.fl_level;
            parameters[25].Value = model.fl_grade;
            parameters[26].Value = model.fl_year;
            parameters[27].Value = model.fl_type;
            parameters[28].Value = model.fl_dep;
            parameters[29].Value = model.com_type;
            parameters[30].Value = model.com_grade;
            parameters[31].Value = model.com_passdate;
            parameters[32].Value = model.exploit;
            parameters[33].Value = model.examine;
            parameters[34].Value = model.award;
            parameters[35].Value = model.maven1;
            parameters[36].Value = model.maven2;
            parameters[37].Value = model.pwhmc;
            parameters[38].Value = model.pwhrs;
            parameters[39].Value = model.cxrs;
            parameters[40].Value = model.zcps;
            parameters[41].Value = model.fdps;
            parameters[42].Value = model.qqps;
            parameters[43].Value = model.hbps;
            parameters[44].Value = model.shsj;
            parameters[45].Value = model.tjbym;
            parameters[46].Value = model.zpw;
            parameters[47].Value = model.zpsj;
            parameters[48].Value = model.cpyj;
            parameters[49].Value = model.pg;
            parameters[50].Value = model.dwmc;
            parameters[51].Value = model.dwdm;
            parameters[52].Value = model.bz;
            parameters[53].Value = model.shenhe;
            parameters[54].Value = model.pingshen;
            parameters[55].Value = model.jl;
            parameters[56].Value = model.cplw;
            parameters[57].Value = model.com_dep;
            parameters[58].Value = model.sk_dep;
            parameters[59].Value = model.com_level;
            parameters[60].Value = model.com_modeln;
            parameters[61].Value = model.sk_year;
            parameters[62].Value = model.sk_kind;
            parameters[63].Value = model.sk_grade;
            parameters[64].Value = model.sk_level;
            parameters[65].Value = model.sk_list;
            parameters[66].Value = model.zsqk;
            parameters[67].Value = model.year;
            parameters[68].Value = model.zylb;

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
        public bool Delete(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from master ");
            strSql.Append(" where ident=@ident and ord=@ord and depart=@depart and name=@name and pinyin=@pinyin and idcode=@idcode and birthday=@birthday and sex=@sex and education=@education and post_name=@post_name and post_rank=@post_rank and post_date=@post_date and grad_date=@grad_date and college=@college and s_major=@s_major and grad_time=@grad_time and w_date=@w_date and zg_date=@zg_date and jg_date=@jg_date and w_major=@w_major and cs_title=@cs_title and cs_date=@cs_date and ds_title=@ds_title and fl_kind=@fl_kind and fl_level=@fl_level and fl_grade=@fl_grade and fl_year=@fl_year and fl_type=@fl_type and fl_dep=@fl_dep and com_type=@com_type and com_grade=@com_grade and com_passdate=@com_passdate and exploit=@exploit and examine=@examine and award=@award and maven1=@maven1 and maven2=@maven2 and pwhmc=@pwhmc and pwhrs=@pwhrs and cxrs=@cxrs and zcps=@zcps and fdps=@fdps and qqps=@qqps and hbps=@hbps and shsj=@shsj and tjbym=@tjbym and zpw=@zpw and zpsj=@zpsj and cpyj=@cpyj and pg=@pg and dwmc=@dwmc and dwdm=@dwdm and bz=@bz and shenhe=@shenhe and pingshen=@pingshen and jl=@jl and cplw=@cplw and com_dep=@com_dep and sk_dep=@sk_dep and com_level=@com_level and com_modeln=@com_modeln and sk_year=@sk_year and sk_kind=@sk_kind and sk_grade=@sk_grade and sk_level=@sk_level and sk_list=@sk_list and zsqk=@zsqk and year=@year and zylb=@zylb ");
            SqlParameter[] parameters = {
					new SqlParameter("@ident", SqlDbType.NVarChar,25),
					new SqlParameter("@ord", SqlDbType.SmallInt,2),
					new SqlParameter("@depart", SqlDbType.NVarChar,6),
					new SqlParameter("@name", SqlDbType.NVarChar,10),
					new SqlParameter("@pinyin", SqlDbType.NVarChar,5),
					new SqlParameter("@idcode", SqlDbType.NVarChar,18),
					new SqlParameter("@birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,2),
					new SqlParameter("@education", SqlDbType.NVarChar,2),
					new SqlParameter("@post_name", SqlDbType.NVarChar,20),
					new SqlParameter("@post_rank", SqlDbType.NVarChar,12),
					new SqlParameter("@post_date", SqlDbType.NVarChar,6),
					new SqlParameter("@grad_date", SqlDbType.NVarChar,6),
					new SqlParameter("@college", SqlDbType.NVarChar,40),
					new SqlParameter("@s_major", SqlDbType.NVarChar,30),
					new SqlParameter("@grad_time", SqlDbType.NVarChar,3),
					new SqlParameter("@w_date", SqlDbType.NVarChar,6),
					new SqlParameter("@zg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@jg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@w_major", SqlDbType.NVarChar,30),
					new SqlParameter("@cs_title", SqlDbType.NVarChar,4),
					new SqlParameter("@cs_date", SqlDbType.NVarChar,6),
					new SqlParameter("@ds_title", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@fl_level", SqlDbType.NVarChar,1),
					new SqlParameter("@fl_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@fl_year", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_type", SqlDbType.NVarChar,20),
					new SqlParameter("@fl_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_type", SqlDbType.NVarChar,20),
					new SqlParameter("@com_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@com_passdate", SqlDbType.NVarChar,4),
					new SqlParameter("@exploit", SqlDbType.NVarChar,-1),
					new SqlParameter("@examine", SqlDbType.NVarChar,-1),
					new SqlParameter("@award", SqlDbType.NVarChar,-1),
					new SqlParameter("@maven1", SqlDbType.NVarChar,6),
					new SqlParameter("@maven2", SqlDbType.NVarChar,6),
					new SqlParameter("@pwhmc", SqlDbType.NVarChar,40),
					new SqlParameter("@pwhrs", SqlDbType.SmallInt,2),
					new SqlParameter("@cxrs", SqlDbType.SmallInt,2),
					new SqlParameter("@zcps", SqlDbType.SmallInt,2),
					new SqlParameter("@fdps", SqlDbType.SmallInt,2),
					new SqlParameter("@qqps", SqlDbType.SmallInt,2),
					new SqlParameter("@hbps", SqlDbType.SmallInt,2),
					new SqlParameter("@shsj", SqlDbType.NVarChar,8),
					new SqlParameter("@tjbym", SqlDbType.SmallInt,2),
					new SqlParameter("@zpw", SqlDbType.NVarChar,6),
					new SqlParameter("@zpsj", SqlDbType.NVarChar,8),
					new SqlParameter("@cpyj", SqlDbType.NVarChar,100),
					new SqlParameter("@pg", SqlDbType.NVarChar,2),
					new SqlParameter("@dwmc", SqlDbType.NVarChar,40),
					new SqlParameter("@dwdm", SqlDbType.NVarChar,6),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@shenhe", SqlDbType.NVarChar,2),
					new SqlParameter("@pingshen", SqlDbType.NVarChar,6),
					new SqlParameter("@jl", SqlDbType.NVarChar,-1),
					new SqlParameter("@cplw", SqlDbType.NVarChar,100),
					new SqlParameter("@com_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_level", SqlDbType.NVarChar,4),
					new SqlParameter("@com_modeln", SqlDbType.Int,4),
					new SqlParameter("@sk_year", SqlDbType.NVarChar,4),
					new SqlParameter("@sk_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_grade", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_level", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_list", SqlDbType.NVarChar,10),
					new SqlParameter("@zsqk", SqlDbType.NVarChar,50),
					new SqlParameter("@year", SqlDbType.NVarChar,25),
					new SqlParameter("@zylb", SqlDbType.NVarChar,50)			};
            parameters[0].Value = ident;
            parameters[1].Value = ord;
            parameters[2].Value = depart;
            parameters[3].Value = name;
            parameters[4].Value = pinyin;
            parameters[5].Value = idcode;
            parameters[6].Value = birthday;
            parameters[7].Value = sex;
            parameters[8].Value = education;
            parameters[9].Value = post_name;
            parameters[10].Value = post_rank;
            parameters[11].Value = post_date;
            parameters[12].Value = grad_date;
            parameters[13].Value = college;
            parameters[14].Value = s_major;
            parameters[15].Value = grad_time;
            parameters[16].Value = w_date;
            parameters[17].Value = zg_date;
            parameters[18].Value = jg_date;
            parameters[19].Value = w_major;
            parameters[20].Value = cs_title;
            parameters[21].Value = cs_date;
            parameters[22].Value = ds_title;
            parameters[23].Value = fl_kind;
            parameters[24].Value = fl_level;
            parameters[25].Value = fl_grade;
            parameters[26].Value = fl_year;
            parameters[27].Value = fl_type;
            parameters[28].Value = fl_dep;
            parameters[29].Value = com_type;
            parameters[30].Value = com_grade;
            parameters[31].Value = com_passdate;
            parameters[32].Value = exploit;
            parameters[33].Value = examine;
            parameters[34].Value = award;
            parameters[35].Value = maven1;
            parameters[36].Value = maven2;
            parameters[37].Value = pwhmc;
            parameters[38].Value = pwhrs;
            parameters[39].Value = cxrs;
            parameters[40].Value = zcps;
            parameters[41].Value = fdps;
            parameters[42].Value = qqps;
            parameters[43].Value = hbps;
            parameters[44].Value = shsj;
            parameters[45].Value = tjbym;
            parameters[46].Value = zpw;
            parameters[47].Value = zpsj;
            parameters[48].Value = cpyj;
            parameters[49].Value = pg;
            parameters[50].Value = dwmc;
            parameters[51].Value = dwdm;
            parameters[52].Value = bz;
            parameters[53].Value = shenhe;
            parameters[54].Value = pingshen;
            parameters[55].Value = jl;
            parameters[56].Value = cplw;
            parameters[57].Value = com_dep;
            parameters[58].Value = sk_dep;
            parameters[59].Value = com_level;
            parameters[60].Value = com_modeln;
            parameters[61].Value = sk_year;
            parameters[62].Value = sk_kind;
            parameters[63].Value = sk_grade;
            parameters[64].Value = sk_level;
            parameters[65].Value = sk_list;
            parameters[66].Value = zsqk;
            parameters[67].Value = year;
            parameters[68].Value = zylb;

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
        public Maticsoft.Model.master GetModel(string ident, int ord, string depart, string name, string pinyin, string idcode, string birthday, string sex, string education, string post_name, string post_rank, string post_date, string grad_date, string college, string s_major, string grad_time, string w_date, string zg_date, string jg_date, string w_major, string cs_title, string cs_date, string ds_title, string fl_kind, string fl_level, string fl_grade, string fl_year, string fl_type, string fl_dep, string com_type, string com_grade, string com_passdate, string exploit, string examine, string award, string maven1, string maven2, string pwhmc, int pwhrs, int cxrs, int zcps, int fdps, int qqps, int hbps, string shsj, int tjbym, string zpw, string zpsj, string cpyj, string pg, string dwmc, string dwdm, string bz, string shenhe, string pingshen, string jl, string cplw, string com_dep, string sk_dep, string com_level, int com_modeln, string sk_year, string sk_kind, string sk_grade, string sk_level, string sk_list, string zsqk, string year, string zylb)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ident,ord,depart,name,pinyin,idcode,birthday,sex,education,post_name,post_rank,post_date,grad_date,college,s_major,grad_time,w_date,zg_date,jg_date,w_major,cs_title,cs_date,ds_title,fl_kind,fl_level,fl_grade,fl_year,fl_type,fl_dep,com_type,com_grade,com_passdate,exploit,examine,award,maven1,maven2,pwhmc,pwhrs,cxrs,zcps,fdps,qqps,hbps,shsj,tjbym,zpw,zpsj,cpyj,pg,dwmc,dwdm,bz,shenhe,pingshen,jl,cplw,com_dep,sk_dep,com_level,com_modeln,sk_year,sk_kind,sk_grade,sk_level,sk_list,zsqk,year,zylb from master ");
            strSql.Append(" where ident=@ident and ord=@ord and depart=@depart and name=@name and pinyin=@pinyin and idcode=@idcode and birthday=@birthday and sex=@sex and education=@education and post_name=@post_name and post_rank=@post_rank and post_date=@post_date and grad_date=@grad_date and college=@college and s_major=@s_major and grad_time=@grad_time and w_date=@w_date and zg_date=@zg_date and jg_date=@jg_date and w_major=@w_major and cs_title=@cs_title and cs_date=@cs_date and ds_title=@ds_title and fl_kind=@fl_kind and fl_level=@fl_level and fl_grade=@fl_grade and fl_year=@fl_year and fl_type=@fl_type and fl_dep=@fl_dep and com_type=@com_type and com_grade=@com_grade and com_passdate=@com_passdate and exploit=@exploit and examine=@examine and award=@award and maven1=@maven1 and maven2=@maven2 and pwhmc=@pwhmc and pwhrs=@pwhrs and cxrs=@cxrs and zcps=@zcps and fdps=@fdps and qqps=@qqps and hbps=@hbps and shsj=@shsj and tjbym=@tjbym and zpw=@zpw and zpsj=@zpsj and cpyj=@cpyj and pg=@pg and dwmc=@dwmc and dwdm=@dwdm and bz=@bz and shenhe=@shenhe and pingshen=@pingshen and jl=@jl and cplw=@cplw and com_dep=@com_dep and sk_dep=@sk_dep and com_level=@com_level and com_modeln=@com_modeln and sk_year=@sk_year and sk_kind=@sk_kind and sk_grade=@sk_grade and sk_level=@sk_level and sk_list=@sk_list and zsqk=@zsqk and year=@year and zylb=@zylb ");
            SqlParameter[] parameters = {
					new SqlParameter("@ident", SqlDbType.NVarChar,25),
					new SqlParameter("@ord", SqlDbType.SmallInt,2),
					new SqlParameter("@depart", SqlDbType.NVarChar,6),
					new SqlParameter("@name", SqlDbType.NVarChar,10),
					new SqlParameter("@pinyin", SqlDbType.NVarChar,5),
					new SqlParameter("@idcode", SqlDbType.NVarChar,18),
					new SqlParameter("@birthday", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,2),
					new SqlParameter("@education", SqlDbType.NVarChar,2),
					new SqlParameter("@post_name", SqlDbType.NVarChar,20),
					new SqlParameter("@post_rank", SqlDbType.NVarChar,12),
					new SqlParameter("@post_date", SqlDbType.NVarChar,6),
					new SqlParameter("@grad_date", SqlDbType.NVarChar,6),
					new SqlParameter("@college", SqlDbType.NVarChar,40),
					new SqlParameter("@s_major", SqlDbType.NVarChar,30),
					new SqlParameter("@grad_time", SqlDbType.NVarChar,3),
					new SqlParameter("@w_date", SqlDbType.NVarChar,6),
					new SqlParameter("@zg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@jg_date", SqlDbType.NVarChar,6),
					new SqlParameter("@w_major", SqlDbType.NVarChar,30),
					new SqlParameter("@cs_title", SqlDbType.NVarChar,4),
					new SqlParameter("@cs_date", SqlDbType.NVarChar,6),
					new SqlParameter("@ds_title", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@fl_level", SqlDbType.NVarChar,1),
					new SqlParameter("@fl_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@fl_year", SqlDbType.NVarChar,4),
					new SqlParameter("@fl_type", SqlDbType.NVarChar,20),
					new SqlParameter("@fl_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_type", SqlDbType.NVarChar,20),
					new SqlParameter("@com_grade", SqlDbType.NVarChar,6),
					new SqlParameter("@com_passdate", SqlDbType.NVarChar,4),
					new SqlParameter("@exploit", SqlDbType.NVarChar,-1),
					new SqlParameter("@examine", SqlDbType.NVarChar,-1),
					new SqlParameter("@award", SqlDbType.NVarChar,-1),
					new SqlParameter("@maven1", SqlDbType.NVarChar,6),
					new SqlParameter("@maven2", SqlDbType.NVarChar,6),
					new SqlParameter("@pwhmc", SqlDbType.NVarChar,40),
					new SqlParameter("@pwhrs", SqlDbType.SmallInt,2),
					new SqlParameter("@cxrs", SqlDbType.SmallInt,2),
					new SqlParameter("@zcps", SqlDbType.SmallInt,2),
					new SqlParameter("@fdps", SqlDbType.SmallInt,2),
					new SqlParameter("@qqps", SqlDbType.SmallInt,2),
					new SqlParameter("@hbps", SqlDbType.SmallInt,2),
					new SqlParameter("@shsj", SqlDbType.NVarChar,8),
					new SqlParameter("@tjbym", SqlDbType.SmallInt,2),
					new SqlParameter("@zpw", SqlDbType.NVarChar,6),
					new SqlParameter("@zpsj", SqlDbType.NVarChar,8),
					new SqlParameter("@cpyj", SqlDbType.NVarChar,100),
					new SqlParameter("@pg", SqlDbType.NVarChar,2),
					new SqlParameter("@dwmc", SqlDbType.NVarChar,40),
					new SqlParameter("@dwdm", SqlDbType.NVarChar,6),
					new SqlParameter("@bz", SqlDbType.NVarChar,-1),
					new SqlParameter("@shenhe", SqlDbType.NVarChar,2),
					new SqlParameter("@pingshen", SqlDbType.NVarChar,6),
					new SqlParameter("@jl", SqlDbType.NVarChar,-1),
					new SqlParameter("@cplw", SqlDbType.NVarChar,100),
					new SqlParameter("@com_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_dep", SqlDbType.NVarChar,10),
					new SqlParameter("@com_level", SqlDbType.NVarChar,4),
					new SqlParameter("@com_modeln", SqlDbType.Int,4),
					new SqlParameter("@sk_year", SqlDbType.NVarChar,4),
					new SqlParameter("@sk_kind", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_grade", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_level", SqlDbType.NVarChar,10),
					new SqlParameter("@sk_list", SqlDbType.NVarChar,10),
					new SqlParameter("@zsqk", SqlDbType.NVarChar,50),
					new SqlParameter("@year", SqlDbType.NVarChar,25),
					new SqlParameter("@zylb", SqlDbType.NVarChar,50)			};
            parameters[0].Value = ident;
            parameters[1].Value = ord;
            parameters[2].Value = depart;
            parameters[3].Value = name;
            parameters[4].Value = pinyin;
            parameters[5].Value = idcode;
            parameters[6].Value = birthday;
            parameters[7].Value = sex;
            parameters[8].Value = education;
            parameters[9].Value = post_name;
            parameters[10].Value = post_rank;
            parameters[11].Value = post_date;
            parameters[12].Value = grad_date;
            parameters[13].Value = college;
            parameters[14].Value = s_major;
            parameters[15].Value = grad_time;
            parameters[16].Value = w_date;
            parameters[17].Value = zg_date;
            parameters[18].Value = jg_date;
            parameters[19].Value = w_major;
            parameters[20].Value = cs_title;
            parameters[21].Value = cs_date;
            parameters[22].Value = ds_title;
            parameters[23].Value = fl_kind;
            parameters[24].Value = fl_level;
            parameters[25].Value = fl_grade;
            parameters[26].Value = fl_year;
            parameters[27].Value = fl_type;
            parameters[28].Value = fl_dep;
            parameters[29].Value = com_type;
            parameters[30].Value = com_grade;
            parameters[31].Value = com_passdate;
            parameters[32].Value = exploit;
            parameters[33].Value = examine;
            parameters[34].Value = award;
            parameters[35].Value = maven1;
            parameters[36].Value = maven2;
            parameters[37].Value = pwhmc;
            parameters[38].Value = pwhrs;
            parameters[39].Value = cxrs;
            parameters[40].Value = zcps;
            parameters[41].Value = fdps;
            parameters[42].Value = qqps;
            parameters[43].Value = hbps;
            parameters[44].Value = shsj;
            parameters[45].Value = tjbym;
            parameters[46].Value = zpw;
            parameters[47].Value = zpsj;
            parameters[48].Value = cpyj;
            parameters[49].Value = pg;
            parameters[50].Value = dwmc;
            parameters[51].Value = dwdm;
            parameters[52].Value = bz;
            parameters[53].Value = shenhe;
            parameters[54].Value = pingshen;
            parameters[55].Value = jl;
            parameters[56].Value = cplw;
            parameters[57].Value = com_dep;
            parameters[58].Value = sk_dep;
            parameters[59].Value = com_level;
            parameters[60].Value = com_modeln;
            parameters[61].Value = sk_year;
            parameters[62].Value = sk_kind;
            parameters[63].Value = sk_grade;
            parameters[64].Value = sk_level;
            parameters[65].Value = sk_list;
            parameters[66].Value = zsqk;
            parameters[67].Value = year;
            parameters[68].Value = zylb;

            Maticsoft.Model.master model = new Maticsoft.Model.master();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.master DataRowToModel(DataRow row)
        {
            Maticsoft.Model.master model = new Maticsoft.Model.master();
            if (row != null)
            {
                if (row["ident"] != null)
                {
                    model.ident = row["ident"].ToString();
                }
                if (row["ord"] != null && row["ord"].ToString() != "")
                {
                    model.ord = int.Parse(row["ord"].ToString());
                }
                if (row["depart"] != null)
                {
                    model.depart = row["depart"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["pinyin"] != null)
                {
                    model.pinyin = row["pinyin"].ToString();
                }
                if (row["idcode"] != null)
                {
                    model.idcode = row["idcode"].ToString();
                }
                if (row["birthday"] != null)
                {
                    model.birthday = row["birthday"].ToString();
                }
                if (row["sex"] != null)
                {
                    model.sex = row["sex"].ToString();
                }
                if (row["education"] != null)
                {
                    model.education = row["education"].ToString();
                }
                if (row["post_name"] != null)
                {
                    model.post_name = row["post_name"].ToString();
                }
                if (row["post_rank"] != null)
                {
                    model.post_rank = row["post_rank"].ToString();
                }
                if (row["post_date"] != null)
                {
                    model.post_date = row["post_date"].ToString();
                }
                if (row["grad_date"] != null)
                {
                    model.grad_date = row["grad_date"].ToString();
                }
                if (row["college"] != null)
                {
                    model.college = row["college"].ToString();
                }
                if (row["s_major"] != null)
                {
                    model.s_major = row["s_major"].ToString();
                }
                if (row["grad_time"] != null)
                {
                    model.grad_time = row["grad_time"].ToString();
                }
                if (row["w_date"] != null)
                {
                    model.w_date = row["w_date"].ToString();
                }
                if (row["zg_date"] != null)
                {
                    model.zg_date = row["zg_date"].ToString();
                }
                if (row["jg_date"] != null)
                {
                    model.jg_date = row["jg_date"].ToString();
                }
                if (row["w_major"] != null)
                {
                    model.w_major = row["w_major"].ToString();
                }
                if (row["cs_title"] != null)
                {
                    model.cs_title = row["cs_title"].ToString();
                }
                if (row["cs_date"] != null)
                {
                    model.cs_date = row["cs_date"].ToString();
                }
                if (row["ds_title"] != null)
                {
                    model.ds_title = row["ds_title"].ToString();
                }
                if (row["fl_kind"] != null)
                {
                    model.fl_kind = row["fl_kind"].ToString();
                }
                if (row["fl_level"] != null)
                {
                    model.fl_level = row["fl_level"].ToString();
                }
                if (row["fl_grade"] != null)
                {
                    model.fl_grade = row["fl_grade"].ToString();
                }
                if (row["fl_year"] != null)
                {
                    model.fl_year = row["fl_year"].ToString();
                }
                if (row["fl_type"] != null)
                {
                    model.fl_type = row["fl_type"].ToString();
                }
                if (row["fl_dep"] != null)
                {
                    model.fl_dep = row["fl_dep"].ToString();
                }
                if (row["com_type"] != null)
                {
                    model.com_type = row["com_type"].ToString();
                }
                if (row["com_grade"] != null)
                {
                    model.com_grade = row["com_grade"].ToString();
                }
                if (row["com_passdate"] != null)
                {
                    model.com_passdate = row["com_passdate"].ToString();
                }
                if (row["exploit"] != null)
                {
                    model.exploit = row["exploit"].ToString();
                }
                if (row["examine"] != null)
                {
                    model.examine = row["examine"].ToString();
                }
                if (row["award"] != null)
                {
                    model.award = row["award"].ToString();
                }
                if (row["maven1"] != null)
                {
                    model.maven1 = row["maven1"].ToString();
                }
                if (row["maven2"] != null)
                {
                    model.maven2 = row["maven2"].ToString();
                }
                if (row["pwhmc"] != null)
                {
                    model.pwhmc = row["pwhmc"].ToString();
                }
                if (row["pwhrs"] != null && row["pwhrs"].ToString() != "")
                {
                    model.pwhrs = int.Parse(row["pwhrs"].ToString());
                }
                if (row["cxrs"] != null && row["cxrs"].ToString() != "")
                {
                    model.cxrs = int.Parse(row["cxrs"].ToString());
                }
                if (row["zcps"] != null && row["zcps"].ToString() != "")
                {
                    model.zcps = int.Parse(row["zcps"].ToString());
                }
                if (row["fdps"] != null && row["fdps"].ToString() != "")
                {
                    model.fdps = int.Parse(row["fdps"].ToString());
                }
                if (row["qqps"] != null && row["qqps"].ToString() != "")
                {
                    model.qqps = int.Parse(row["qqps"].ToString());
                }
                if (row["hbps"] != null && row["hbps"].ToString() != "")
                {
                    model.hbps = int.Parse(row["hbps"].ToString());
                }
                if (row["shsj"] != null)
                {
                    model.shsj = row["shsj"].ToString();
                }
                if (row["tjbym"] != null && row["tjbym"].ToString() != "")
                {
                    model.tjbym = int.Parse(row["tjbym"].ToString());
                }
                if (row["zpw"] != null)
                {
                    model.zpw = row["zpw"].ToString();
                }
                if (row["zpsj"] != null)
                {
                    model.zpsj = row["zpsj"].ToString();
                }
                if (row["cpyj"] != null)
                {
                    model.cpyj = row["cpyj"].ToString();
                }
                if (row["pg"] != null)
                {
                    model.pg = row["pg"].ToString();
                }
                if (row["dwmc"] != null)
                {
                    model.dwmc = row["dwmc"].ToString();
                }
                if (row["dwdm"] != null)
                {
                    model.dwdm = row["dwdm"].ToString();
                }
                if (row["bz"] != null)
                {
                    model.bz = row["bz"].ToString();
                }
                if (row["shenhe"] != null)
                {
                    model.shenhe = row["shenhe"].ToString();
                }
                if (row["pingshen"] != null)
                {
                    model.pingshen = row["pingshen"].ToString();
                }
                if (row["jl"] != null)
                {
                    model.jl = row["jl"].ToString();
                }
                if (row["cplw"] != null)
                {
                    model.cplw = row["cplw"].ToString();
                }
                if (row["com_dep"] != null)
                {
                    model.com_dep = row["com_dep"].ToString();
                }
                if (row["sk_dep"] != null)
                {
                    model.sk_dep = row["sk_dep"].ToString();
                }
                if (row["com_level"] != null)
                {
                    model.com_level = row["com_level"].ToString();
                }
                if (row["com_modeln"] != null && row["com_modeln"].ToString() != "")
                {
                    model.com_modeln = int.Parse(row["com_modeln"].ToString());
                }
                if (row["sk_year"] != null)
                {
                    model.sk_year = row["sk_year"].ToString();
                }
                if (row["sk_kind"] != null)
                {
                    model.sk_kind = row["sk_kind"].ToString();
                }
                if (row["sk_grade"] != null)
                {
                    model.sk_grade = row["sk_grade"].ToString();
                }
                if (row["sk_level"] != null)
                {
                    model.sk_level = row["sk_level"].ToString();
                }
                if (row["sk_list"] != null)
                {
                    model.sk_list = row["sk_list"].ToString();
                }
                if (row["zsqk"] != null)
                {
                    model.zsqk = row["zsqk"].ToString();
                }
                if (row["year"] != null)
                {
                    model.year = row["year"].ToString();
                }
                if (row["zylb"] != null)
                {
                    model.zylb = row["zylb"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ident,ord,depart,name,pinyin,idcode,birthday,sex,education,post_name,post_rank,post_date,grad_date,college,s_major,grad_time,w_date,zg_date,jg_date,w_major,cs_title,cs_date,ds_title,fl_kind,fl_level,fl_grade,fl_year,fl_type,fl_dep,com_type,com_grade,com_passdate,exploit,examine,award,maven1,maven2,pwhmc,pwhrs,cxrs,zcps,fdps,qqps,hbps,shsj,tjbym,zpw,zpsj,cpyj,pg,dwmc,dwdm,bz,shenhe,pingshen,jl,cplw,com_dep,sk_dep,com_level,com_modeln,sk_year,sk_kind,sk_grade,sk_level,sk_list,zsqk,year,zylb ");
            strSql.Append(" FROM master ");
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
            strSql.Append(" ident,ord,depart,name,pinyin,idcode,birthday,sex,education,post_name,post_rank,post_date,grad_date,college,s_major,grad_time,w_date,zg_date,jg_date,w_major,cs_title,cs_date,ds_title,fl_kind,fl_level,fl_grade,fl_year,fl_type,fl_dep,com_type,com_grade,com_passdate,exploit,examine,award,maven1,maven2,pwhmc,pwhrs,cxrs,zcps,fdps,qqps,hbps,shsj,tjbym,zpw,zpsj,cpyj,pg,dwmc,dwdm,bz,shenhe,pingshen,jl,cplw,com_dep,sk_dep,com_level,com_modeln,sk_year,sk_kind,sk_grade,sk_level,sk_list,zsqk,year,zylb ");
            strSql.Append(" FROM master ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM master ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.zylb desc");
            }
            strSql.Append(")AS Row, T.*  from master T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "master";
            parameters[1].Value = "zylb";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


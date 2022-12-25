using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnTap_24_12.Models;
namespace OnTap_24_12.Controllers
{

    public class DefaultController : ApiController
    {
        THDB db = new THDB();
        // list sv
        [HttpGet]
        [Route("api/default/listsv")]
        public List<sinhvien> getlist()
        {
            return db.sinhviens.ToList();
        }
        // list sv theo lop
        [HttpGet]
        [Route("api/default/svtheolop")]
        public List<sinhvien> getlist(int malop)
        {
            return db.sinhviens.Where(s => s.malop == malop).ToList();
        }
        // tim sv theo masv
        [HttpGet]
        [Route("api/default/timsv")]
        public sinhvien getsv(int masv)
        {
            return db.sinhviens.SingleOrDefault(s => s.masv == masv);
        }
        // them sv
        [HttpPost]
        [Route("api/default/themsv")]
        public bool themsv(sinhvien sv)
        {
            try{
                db.sinhviens.Add(sv);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("loi " + ex.Message);
                return false;
            }
        }
        // them sv
        [HttpPut]
        [Route("api/default/suasv")]
        public bool suasv(sinhvien sv)
        {
            try
            {
                sinhvien svs = db.sinhviens.SingleOrDefault(s => s.masv == sv.masv);
                svs.hoten = sv.hoten;
                svs.diachi = sv.diachi;
                svs.dienthoai = sv.dienthoai;
                svs.malop = sv.malop;
                svs.anh = sv.anh;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("loi " + ex.Message);
                return false;
            }
        }
        // xoa sv
        [HttpDelete]
        [Route("api/default/xoasv")]
        public bool xoasv(int masv)
        {
            sinhvien  svx = db.sinhviens.SingleOrDefault(s=> s.masv == masv);
            if(svx != null)
            {
                db.sinhviens.Remove(svx);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpGet]
        [Route("api/default/lophoc")]
        public List<lophoc> getLopHoc()
        {
            return db.lophocs.ToList();
        }
    }
}

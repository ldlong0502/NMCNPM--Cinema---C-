using ManageCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ManageCinema.DAO;

namespace ManageCinema.DAO
{
    public class CinemaDAO
    {
        public static Cinema GetCinemaByName(string cinemaName)
        {
            string query = "select * from dbo.PhongChieu where TenPhong = '" + cinemaName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return new Cinema(data.Rows[0]);
        }

        public static Cinema GetCinemaByID(string id)
        {
            string query = "select * from dbo.PhongChieu where id = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return new Cinema(data.Rows[0]);
            return null;
        }

        public static List<Cinema> GetCinemaByScreenTypeID(string screenTypeID)
        {
            List<Cinema> cinemaList = new List<Cinema>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhongChieu where idManHinh ='" + screenTypeID + "'");
            foreach (DataRow item in data.Rows)
            {
                Cinema cinema = new Cinema(item);
                cinemaList.Add(cinema);
            }
            return cinemaList;
        }

        public static DataTable GetListCinema()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetCinema");
        }

        public static bool InsertCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertCinema @idCinema , @tenPhong , @idMH , @soChoNgoi , @tinhTrang , @soHangGhe , @soGheMotHang", new object[] { id, name, idMH, seats, status, numberOfRows, seatsPerRow });
            return result > 0;
        }

        public static bool UpdateCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            string command = string.Format("UPDATE dbo.PhongChieu SET TenPhong = N'{0}', idManHinh = '{1}', SoChoNgoi = {2}, TinhTrang = {3}, SoHangGhe = {4}, SoGheMotHang = {5} WHERE id = '{6}'", name, idMH, seats, status, numberOfRows, seatsPerRow, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteCinema(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.LichChieu WHERE idPhong = '" + id + "'");

            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhongChieu WHERE id = '" + id + "'");
            return result > 0;
        }
    }
}

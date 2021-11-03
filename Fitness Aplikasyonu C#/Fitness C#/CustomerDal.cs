using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public class CustomerDal 
    {
        SqlConnection _connection = new SqlConnection("Server=EMRE\\SQLEXPRESS02;Initial Catalog=Fitness;Integrated Security=True");
        public DataTable GetAllList()
        { 
            _connection.Open();
            SqlCommand command = new SqlCommand("Select * from uyeler",_connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            reader.Close();
            _connection.Close();
            return datatable;
        } 
        public void musteriekle(Customer customer)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("insert into uyeler(uyeAdi,uyeSoyadi,cinsiyet,telefon,yas,uyeKilo,uyeBoy,uyeKol,uyeGogus,uyeBel,uyeOmuz) values(@uyeAdi,@uyeSoyadi,@cinsiyet,@telefon,@yas,@uyeKilo,@uyeBoy,@uyeKol,@uyeGogus,@uyeBel,@uyeOmuz)",_connection);
            command.Parameters.AddWithValue("@uyeAdi", customer.uyeAdi);
            command.Parameters.AddWithValue("@uyeSoyadi", customer.uyeSoyadi);
            command.Parameters.AddWithValue("@cinsiyet", customer.cinsiyet);
            command.Parameters.AddWithValue("@telefon", customer.telefon);
            command.Parameters.AddWithValue("@yas", customer.yas);
            command.Parameters.AddWithValue("@uyeKilo", customer.uyeKilo);
            command.Parameters.AddWithValue("@uyeBoy", customer.uyeBoy);
            command.Parameters.AddWithValue("@uyeKol", customer.uyeKol);
            command.Parameters.AddWithValue("@uyeGogus", customer.uyeGogus);
            command.Parameters.AddWithValue("@uyeBel", customer.uyeBel);
            command.Parameters.AddWithValue("@uyeOmuz", customer.uyeOmuz);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void musteriguncelle(Customer customer)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("update uyeler set uyeAdi=@uyeAdi,uyeSoyadi=@uyeSoyadi,cinsiyet=@cinsiyet,telefon=@telefon,yas=@yas,uyeKilo=@uyeKilo,uyeBoy=@uyeBoy,uyeKol=@uyeKol,uyeGogus=@uyeGogus,uyeBel=@uyeBel,uyeOmuz=@UyeOmuz where uyeId=@uyeId",_connection);
            command.Parameters.AddWithValue("@uyeId", customer.uyeId);
            command.Parameters.AddWithValue("@uyeAdi", customer.uyeAdi);
            command.Parameters.AddWithValue("@uyeSoyadi", customer.uyeSoyadi);
            command.Parameters.AddWithValue("@cinsiyet", customer.cinsiyet);
            command.Parameters.AddWithValue("@telefon", customer.telefon);
            command.Parameters.AddWithValue("@yas", customer.yas);
            command.Parameters.AddWithValue("@uyeKilo", customer.uyeKilo);
            command.Parameters.AddWithValue("@uyeBoy", customer.uyeBoy);
            command.Parameters.AddWithValue("@uyeKol", customer.uyeKol);
            command.Parameters.AddWithValue("@uyeGogus", customer.uyeGogus);
            command.Parameters.AddWithValue("@uyeBel", customer.uyeBel);
            command.Parameters.AddWithValue("@uyeOmuz", customer.uyeOmuz);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void musteriSil(Customer customer)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("delete from uyeler where uyeId=@uyeId",_connection);
            command.Parameters.AddWithValue("UyeId",customer.uyeId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    public DataTable odemeGetir()
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("select uyeler.uyeId,uyeler.uyeAdi,uyeler.uyeSoyadi,odemeler.odenenay,odemeler.odenentutar from uyeler inner join odemeler on uyeler.uyeId=odemeler.uyeId", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            reader.Close();
            _connection.Close();
            return datatable;
        }
    public void odemeEkle(Odeme odeme)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("insert into odemeler (uyeId,odenenay,odenentutar) values(@uyeId,@odenenay,@odenentutar)", _connection);
            command.Parameters.AddWithValue("@uyeId",odeme.uyeId);
            command.Parameters.AddWithValue("@odenenay", odeme.odenenay);
            command.Parameters.AddWithValue("@odenentutar", odeme.odenentutar);
            command.ExecuteNonQuery();
            _connection.Close();

        }
    }
}

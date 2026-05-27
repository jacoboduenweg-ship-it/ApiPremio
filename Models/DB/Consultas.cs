using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPremio.Models.DB
{
    public class Consultas
    {
        public static DataTable AvisosIndividuales(int iddist)
        {
            
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"avisosindividuales_api_app {iddist}");


            return _consulta;

        }

        public static DataTable AvisosGenerales()
        {

            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT titulo, aviso, fechavencimiento FROM avisos WHERE idusuario IS NULL AND status = 'S' AND GETDATE() <= fechavencimiento ");


            return _consulta;

        }

        public static DataTable Comisiones()
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT comision FROM comisiones ORDER BY orden");


            return _consulta;
        }

        public static DataTable LiberarListado(int idcliente)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT fechalistado FROM liberarlistados WHERE idcliente = {idcliente}");

            return _consulta;
        }

        public static DataTable infopagare(int idpagare)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT TOP 1  pd.prestamo montovale, pp.pago pago, pp.numpago numpago, pp.fechapago fechapago, pp.numquincenas quincenas FROM pagaresdetalle pd, pagaresperiodos pp WHERE pd.idpagare = {idpagare} AND pp.idpagare = pd.idpagare AND pp.idrecibo IS NULL");

            return _consulta;
        }

        public static DataTable diascomision()
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT dias FROM diascomision");

            return _consulta;
        }


        public static DataTable infomonto()
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT monto FROM tiposprestamodetalle WHERE monto <= 10000 GROUP BY monto");

            return _consulta;

        }

        public static DataTable infoplazos(int monto)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT periodo FROM tiposprestamodetalle WHERE monto = {monto} AND status = 'S' ORDER BY periodo");

            return _consulta;
        }

        public static DataTable consultacliente(string nombre1, string nombre2, string appaterno, string apmaterno)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT idcliente FROM clientes WHERE nombre1 = '{nombre1}' AND nombre2 = '{nombre2}' AND appaterno = '{appaterno}' AND apmaterno = '{apmaterno}'");

            return _consulta;
        }

        public static DataTable consultacliente2(string nombre1, string appaterno, string apmaterno)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT idcliente FROM clientes WHERE nombre1 = '{nombre1}' AND appaterno = '{appaterno}' AND apmaterno = '{apmaterno}'");

            return _consulta;
        }

        public static DataTable valesvirtuales(string nombrecliente, int iddist, string status, int folio, int monto, int plazo)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"INSERT INTO valesvirtuales(folio, iddist, clientenuevo, fecha, status, monto, plazo, nombrecliente) VALUES({folio}, {iddist}, 'Q', GETDATE(), '{status}',{monto}, {plazo}, '{nombrecliente}')");
            
            return _consulta;
        }
        public static DataTable verificarvalev(int folio)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT iddist, nombrecliente, folio FROM valesvirtuales WHERE folio = {folio}");

            return _consulta;
        }
        public static DataTable buscarcontra(int id)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT contrasena FROM usuariosapp WHERE iddistribuidor = {id}");

            return _consulta;
        }
        public static DataTable actualizarcontra(int id, string contrasena)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"UPDATE usuariosapp SET contrasena = '{contrasena}', status = 'S' WHERE iddistribuidor = {id}");

            return _consulta;
        }
 
        public static DataTable cancelarvale(int id)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"UPDATE valesvirtuales SET status = 'C' WHERE folio = {id}");

            return _consulta;
        } 
        public static DataTable usuarios(string usuario)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT usuario, contrasena, status, iddistribuidor FROM usuariosapp WHERE usuario = '{usuario}'");

            return _consulta;
        }
  

        public static DataTable valesdisp(int dist)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT folio FROM valesvirtuales WHERE nombrecliente IS NULL AND iddist =  {dist}");

            return _consulta;
        }

        public static DataTable ultimofolio()
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT TOP 1 folio FROM valesvirtuales ORDER BY folio DESC");

            return _consulta;
        }


        public static DataTable checarcliente(string nombre)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT idcliente FROM clientes WHERE REPLACE(RTRIM(nombre1), ' ', '') + REPLACE(RTRIM(nombre2), ' ', '') + REPLACE(RTRIM(appaterno), ' ', '') + REPLACE(RTRIM(apmaterno), ' ', '') = '{nombre}'");

            return _consulta;
        }

        public static DataTable numerovales(int idcliente)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT COUNT(*) numerovales FROM pagares WHERE idcliente = {idcliente} AND status <> 'C'");

            return _consulta;
        }

        public static DataTable listavales(int dist)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT folio, nombrecliente, fecha, monto, plazo FROM valesvirtuales WHERE iddist = {dist}");

            return _consulta;
        }
        public static DataTable infodist(int idcliente)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT RTRIM(ISNULL(nombre1, '')) nombre1,  RTRIM(ISNULL(nombre2, '')) nombre2, RTRIM(ISNULL(appaterno, '')) appaterno, RTRIM(ISNULL(apmaterno, '')) apmaterno, RTRIM(ISNULL(calle, '')) calle,  RTRIM(ISNULL(colonia, '')) colonia, RTRIM(ISNULL(codpostal, 0)) codpostal,  RTRIM(ISNULL(status, '')) status, RTRIM(ISNULL(numdistribuidor, '')) numdistribuidor, RTRIM(ISNULL(telefono, '')) telefono FROM clientes WHERE idcliente = {idcliente}");

            return _consulta;
        }

        public static DataTable saldo(int numdist)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"exec creditodisp_api_app {numdist}");

            return _consulta;
        }

        public static DataTable idpagare(int folio)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT idpagare FROM valesvirtuales WHERE folio = {folio}");

            return _consulta;
        }
        public static DataTable idpagaresinvirtual(int folio)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT idpagare FROM vales WHERE folio = {folio}");

            return _consulta;
        }
        public static DataTable change_reimpresion(int id)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"UPDATE pagares SET reimpresion_recibo = 1 WHERE idpagare = ${id} ");

            return _consulta;
        }

        public static DataTable get_reimpresion(int id)
        {
            DataTable _consulta = new DataTable();

            _consulta = DBConn.ConsultaSQL($"SELECT reimpresion_recibo FROM pagares WHERE idpagare = ${id}");

            return _consulta;
        }

    }
}

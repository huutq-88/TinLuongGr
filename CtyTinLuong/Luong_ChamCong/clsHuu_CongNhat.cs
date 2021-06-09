///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Huu_CongNhat'
// Generated by LLBLGen v1.3.5996.26197 Final on: Sunday, March 21, 2021, 2:44:55 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace CtyTinLuong
{
	/// <summary>
	/// Purpose: Data Access class for the table 'Huu_CongNhat'.
	/// </summary>
	public partial class clsHuu_CongNhat : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bGuiDuLieu, m_bTonTai, m_bNgungTheoDoi;
			private SqlDecimal		m_dcTamUng, m_dcTruTienAn, m_dcBaoHiem, m_dcThucNhan, m_dcSoTienDaTraLuong, m_dcTrachNhiem, m_dcPhuCapXangXe, m_dcTongLuong, m_dcPhuCapDienthoai, m_dcPhuCapTienAn, m_dcPhuCapVeSinhMay;
			private SqlInt32		m_iThang, m_iNam, m_iID_ChamCong;
			private SqlString		m_sGhiChu;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsHuu_CongNhat()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>dcTongLuong</LI>
		///		 <LI>dcPhuCapXangXe</LI>
		///		 <LI>dcPhuCapDienthoai</LI>
		///		 <LI>dcPhuCapVeSinhMay</LI>
		///		 <LI>dcPhuCapTienAn</LI>
		///		 <LI>dcTrachNhiem</LI>
		///		 <LI>dcTruTienAn</LI>
		///		 <LI>dcTamUng</LI>
		///		 <LI>dcBaoHiem</LI>
		///		 <LI>dcSoTienDaTraLuong</LI>
		///		 <LI>dcThucNhan</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_ChamCong</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTongLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTongLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapXangXe", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapXangXe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapDienthoai", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapDienthoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapVeSinhMay", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapVeSinhMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapTienAn", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapTienAn));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTrachNhiem", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTrachNhiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTruTienAn", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTruTienAn));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTamUng", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTamUng));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcBaoHiem", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcBaoHiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcSoTienDaTraLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcSoTienDaTraLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcThucNhan", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcThucNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_ChamCong = (SqlInt32)scmCmdToExecute.Parameters["@iID_ChamCong"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_ChamCong</LI>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>dcTongLuong</LI>
		///		 <LI>dcPhuCapXangXe</LI>
		///		 <LI>dcPhuCapDienthoai</LI>
		///		 <LI>dcPhuCapVeSinhMay</LI>
		///		 <LI>dcPhuCapTienAn</LI>
		///		 <LI>dcTrachNhiem</LI>
		///		 <LI>dcTruTienAn</LI>
		///		 <LI>dcTamUng</LI>
		///		 <LI>dcBaoHiem</LI>
		///		 <LI>dcSoTienDaTraLuong</LI>
		///		 <LI>dcThucNhan</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTongLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTongLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapXangXe", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapXangXe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapDienthoai", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapDienthoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapVeSinhMay", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapVeSinhMay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcPhuCapTienAn", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcPhuCapTienAn));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTrachNhiem", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTrachNhiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTruTienAn", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTruTienAn));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTamUng", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTamUng));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcBaoHiem", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcBaoHiem));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcSoTienDaTraLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcSoTienDaTraLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcThucNhan", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcThucNhan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bGuiDuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bGuiDuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_ChamCong</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID_ChamCong</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_ChamCong</LI>
		///		 <LI>iThang</LI>
		///		 <LI>iNam</LI>
		///		 <LI>dcTongLuong</LI>
		///		 <LI>dcPhuCapXangXe</LI>
		///		 <LI>dcPhuCapDienthoai</LI>
		///		 <LI>dcPhuCapVeSinhMay</LI>
		///		 <LI>dcPhuCapTienAn</LI>
		///		 <LI>dcTrachNhiem</LI>
		///		 <LI>dcTruTienAn</LI>
		///		 <LI>dcTamUng</LI>
		///		 <LI>dcBaoHiem</LI>
		///		 <LI>dcSoTienDaTraLuong</LI>
		///		 <LI>dcThucNhan</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bGuiDuLieu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Huu_CongNhat");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_ChamCong = (Int32)dtToReturn.Rows[0]["ID_ChamCong"];
					m_iThang = (Int32)dtToReturn.Rows[0]["Thang"];
					m_iNam = (Int32)dtToReturn.Rows[0]["Nam"];
					m_dcTongLuong = (Decimal)dtToReturn.Rows[0]["TongLuong"];
					m_dcPhuCapXangXe = (Decimal)dtToReturn.Rows[0]["PhuCapXangXe"];
					m_dcPhuCapDienthoai = (Decimal)dtToReturn.Rows[0]["PhuCapDienthoai"];
					m_dcPhuCapVeSinhMay = (Decimal)dtToReturn.Rows[0]["PhuCapVeSinhMay"];
					m_dcPhuCapTienAn = (Decimal)dtToReturn.Rows[0]["PhuCapTienAn"];
					m_dcTrachNhiem = (Decimal)dtToReturn.Rows[0]["TrachNhiem"];
					m_dcTruTienAn = (Decimal)dtToReturn.Rows[0]["TruTienAn"];
					m_dcTamUng = (Decimal)dtToReturn.Rows[0]["TamUng"];
					m_dcBaoHiem = (Decimal)dtToReturn.Rows[0]["BaoHiem"];
					m_dcSoTienDaTraLuong = (Decimal)dtToReturn.Rows[0]["SoTienDaTraLuong"];
					m_dcThucNhan = (Decimal)dtToReturn.Rows[0]["ThucNhan"];
					m_sGhiChu = (string)dtToReturn.Rows[0]["GhiChu"];
					m_bGuiDuLieu = (bool)dtToReturn.Rows[0]["GuiDuLieu"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_Huu_CongNhat_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("Huu_CongNhat");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_Huu_CongNhat_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsHuu_CongNhat::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 iID_ChamCong
		{
			get
			{
				return m_iID_ChamCong;
			}
			set
			{
				SqlInt32 iID_ChamCongTmp = (SqlInt32)value;
				if(iID_ChamCongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_ChamCong", "iID_ChamCong can't be NULL");
				}
				m_iID_ChamCong = value;
			}
		}


		public SqlInt32 iThang
		{
			get
			{
				return m_iThang;
			}
			set
			{
				SqlInt32 iThangTmp = (SqlInt32)value;
				if(iThangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iThang", "iThang can't be NULL");
				}
				m_iThang = value;
			}
		}


		public SqlInt32 iNam
		{
			get
			{
				return m_iNam;
			}
			set
			{
				SqlInt32 iNamTmp = (SqlInt32)value;
				if(iNamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iNam", "iNam can't be NULL");
				}
				m_iNam = value;
			}
		}


		public SqlDecimal dcTongLuong
		{
			get
			{
				return m_dcTongLuong;
			}
			set
			{
				SqlDecimal dcTongLuongTmp = (SqlDecimal)value;
				if(dcTongLuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcTongLuong", "dcTongLuong can't be NULL");
				}
				m_dcTongLuong = value;
			}
		}


		public SqlDecimal dcPhuCapXangXe
		{
			get
			{
				return m_dcPhuCapXangXe;
			}
			set
			{
				SqlDecimal dcPhuCapXangXeTmp = (SqlDecimal)value;
				if(dcPhuCapXangXeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcPhuCapXangXe", "dcPhuCapXangXe can't be NULL");
				}
				m_dcPhuCapXangXe = value;
			}
		}


		public SqlDecimal dcPhuCapDienthoai
		{
			get
			{
				return m_dcPhuCapDienthoai;
			}
			set
			{
				SqlDecimal dcPhuCapDienthoaiTmp = (SqlDecimal)value;
				if(dcPhuCapDienthoaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcPhuCapDienthoai", "dcPhuCapDienthoai can't be NULL");
				}
				m_dcPhuCapDienthoai = value;
			}
		}


		public SqlDecimal dcPhuCapVeSinhMay
		{
			get
			{
				return m_dcPhuCapVeSinhMay;
			}
			set
			{
				SqlDecimal dcPhuCapVeSinhMayTmp = (SqlDecimal)value;
				if(dcPhuCapVeSinhMayTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcPhuCapVeSinhMay", "dcPhuCapVeSinhMay can't be NULL");
				}
				m_dcPhuCapVeSinhMay = value;
			}
		}


		public SqlDecimal dcPhuCapTienAn
		{
			get
			{
				return m_dcPhuCapTienAn;
			}
			set
			{
				SqlDecimal dcPhuCapTienAnTmp = (SqlDecimal)value;
				if(dcPhuCapTienAnTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcPhuCapTienAn", "dcPhuCapTienAn can't be NULL");
				}
				m_dcPhuCapTienAn = value;
			}
		}


		public SqlDecimal dcTrachNhiem
		{
			get
			{
				return m_dcTrachNhiem;
			}
			set
			{
				SqlDecimal dcTrachNhiemTmp = (SqlDecimal)value;
				if(dcTrachNhiemTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcTrachNhiem", "dcTrachNhiem can't be NULL");
				}
				m_dcTrachNhiem = value;
			}
		}


		public SqlDecimal dcTruTienAn
		{
			get
			{
				return m_dcTruTienAn;
			}
			set
			{
				SqlDecimal dcTruTienAnTmp = (SqlDecimal)value;
				if(dcTruTienAnTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcTruTienAn", "dcTruTienAn can't be NULL");
				}
				m_dcTruTienAn = value;
			}
		}


		public SqlDecimal dcTamUng
		{
			get
			{
				return m_dcTamUng;
			}
			set
			{
				SqlDecimal dcTamUngTmp = (SqlDecimal)value;
				if(dcTamUngTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcTamUng", "dcTamUng can't be NULL");
				}
				m_dcTamUng = value;
			}
		}


		public SqlDecimal dcBaoHiem
		{
			get
			{
				return m_dcBaoHiem;
			}
			set
			{
				SqlDecimal dcBaoHiemTmp = (SqlDecimal)value;
				if(dcBaoHiemTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcBaoHiem", "dcBaoHiem can't be NULL");
				}
				m_dcBaoHiem = value;
			}
		}


		public SqlDecimal dcSoTienDaTraLuong
		{
			get
			{
				return m_dcSoTienDaTraLuong;
			}
			set
			{
				SqlDecimal dcSoTienDaTraLuongTmp = (SqlDecimal)value;
				if(dcSoTienDaTraLuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcSoTienDaTraLuong", "dcSoTienDaTraLuong can't be NULL");
				}
				m_dcSoTienDaTraLuong = value;
			}
		}


		public SqlDecimal dcThucNhan
		{
			get
			{
				return m_dcThucNhan;
			}
			set
			{
				SqlDecimal dcThucNhanTmp = (SqlDecimal)value;
				if(dcThucNhanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcThucNhan", "dcThucNhan can't be NULL");
				}
				m_dcThucNhan = value;
			}
		}


		public SqlString sGhiChu
		{
			get
			{
				return m_sGhiChu;
			}
			set
			{
				SqlString sGhiChuTmp = (SqlString)value;
				if(sGhiChuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sGhiChu", "sGhiChu can't be NULL");
				}
				m_sGhiChu = value;
			}
		}


		public SqlBoolean bGuiDuLieu
		{
			get
			{
				return m_bGuiDuLieu;
			}
			set
			{
				SqlBoolean bGuiDuLieuTmp = (SqlBoolean)value;
				if(bGuiDuLieuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bGuiDuLieu", "bGuiDuLieu can't be NULL");
				}
				m_bGuiDuLieu = value;
			}
		}


		public SqlBoolean bTonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTonTai", "bTonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}


		public SqlBoolean bNgungTheoDoi
		{
			get
			{
				return m_bNgungTheoDoi;
			}
			set
			{
				SqlBoolean bNgungTheoDoiTmp = (SqlBoolean)value;
				if(bNgungTheoDoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bNgungTheoDoi", "bNgungTheoDoi can't be NULL");
				}
				m_bNgungTheoDoi = value;
			}
		}
		#endregion
	}
}
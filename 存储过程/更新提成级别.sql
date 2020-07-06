-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE z_update_percentage(@gsbm VARCHAR(50))
	
AS

update p_spjcxx_sz set lb2bm='000014' 

update p_spjcxx_sz set lb2bm='000001' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.80 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000002' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.70 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.80 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000003' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.60 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.70 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000004' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.50 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.60 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000005' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.40 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.50 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000006' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.30 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.40 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000007' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.20 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.30 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000008' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.10 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.20 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000009' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) >= 0.01 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.10 and dm=@gsbm and isnull(cbj,0) > 0)

update p_spjcxx_sz set lb2bm='000010' where bm in (select bm from p_spjcxx_sz_fd where (case isnull(lsj,0) when 0 then -1 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end) > 0.00 and (case isnull(lsj,0) when 0 then 2 else (isnull(lsj,0) - isnull(cbj,0))/isnull(lsj,0) end)< 0.01 and dm=@gsbm and isnull(cbj,0) > 0)



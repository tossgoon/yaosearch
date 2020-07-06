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
-- Description:	<Description,,>'2016/03/01'
-- =============================================
CREATE PROCEDURE z_select_unsalable (@begindate VARCHAR(50),@enddate VARCHAR(50),@buydate  VARCHAR(50))
AS
BEGIN
SELECT sz.mc as ypmc,sz.sccj,sz.gg,sz.jdrq,kc.sl1,kc.pc,kc.yxqx,gys.mc,kc.dj
FROM
(SELECT * FROM kcgl_spkcxx WHERE SUBSTRING(lsh,6,10)<=@buydate
 AND bm NOT IN(SELECT DISTINCT bm FROM sale_xsd_xx WHERE SUBSTRING(lsh,6,10)>=@begindate and SUBSTRING(lsh,6,10) <=@enddate))kc
 INNER JOIN
(SELECT * FROM  p_spjcxx_sz WHERE lbbm<>'030101') sz
 ON kc.bm=sz.bm 
 LEFT JOIN 
 p_gysxx_wh gys ON kc.gysbm=gys.bm
END
GO

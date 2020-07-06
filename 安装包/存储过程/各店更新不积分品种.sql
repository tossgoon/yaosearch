/*-------------各店更新不积分品种
@dm:店码 001 002 003
@lilv:利率
*/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE z_update_jifen(@dm VARCHAR(50),@lilv DECIMAL(18,6))
AS
BEGIN

DELETE FROM p_splb_sp WHERE lbbm='02000003'
INSERT INTO p_splb_sp (dm,lbbm,spbm) SELECT @dm,'02000003',bm FROM p_spjcxx_sz
DELETE FROM p_splb_sp 
   WHERE spbm not in (SELECT bm FROM p_spjcxx_sz_fd WHERE dm=@dm and cbj > 0 
     AND (SELECT fhyr_sj FROM ls_spsj WHERE dm=@dm and lbbm='000001' AND spbm=p_spjcxx_sz_fd.bm)>0 
     AND ((SELECT fhyr_sj FROM ls_spsj WHERE dm=@dm and lbbm='000001' AND spbm=p_spjcxx_sz_fd.bm) - cbj)/(SELECT fhyr_sj FROM ls_spsj WHERE dm=@dm and lbbm='000001' and spbm=p_spjcxx_sz_fd.bm) >@lilv)
END


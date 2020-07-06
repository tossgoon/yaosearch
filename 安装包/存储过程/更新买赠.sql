/*
2016-07-06
p_spjcxx_sz Ʒ��
p_spjcxx_sz_fd �۸�
ls_spsj      ��Ա��

�������
1.���ۼ�>2.4
2.������ڡ�ɢװ��Ƭ������ԺƷ�֡�    ����Ʒ\�Ĳģ�������Ŀ��
3.���ʼ���  @lilv= (lsj-cbj)/lsj
            lilv:  0.773-1                2+1
            lilv:  0.58-0.773             3+1
	        0.464-0.58                    4+1
            0.387-0.464                   5+1
		    0.331-0.387                   6+1
            0.29-0.331                    7+1
	        0.258-0.29                    8+1
4. �����ƽ���ۼ�Ҫ����Ա�۱Ƚϣ�ƽ���ۼ۵��ڻ�Ա�۲Ž���������001���fhyr_sj�Ƚϣ����������hyr_sj�Ƚ�


*/
GO
/****** Object:  StoredProcedure [dbo].[z_update_pinming_ppc]    Script Date: 07/06/2016 08:55:23 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[z_update_pinming_ppc]
AS

DECLARE @bm VARCHAR(50), --ҩƷ����
        @lsj DECIMAL(18,6), --���ۼ�
        @cbj DECIMAL(18,6),--�ɱ���
        @lilv DECIMAL(18,6),--����
        @buyNum Int, --��������Ļ���
        @oldname VARCHAR(50),--ԭ�ַ���
        @hyj DECIMAL(18,6),--��Ա��
        @avgsj DECIMAL(18,6)--�������ƽ���ۼ�
--��������
DECLARE @tb_temp_ppc TABLE
(
    bm VARCHAR(50),
    cbj DECIMAL(18,6),
    lsj DECIMAL(18,6)
);
--��������
INSERT INTO @tb_temp_ppc(bm,cbj,lsj)
SELECT  fd.bm,fd.cbj,fd.lsj FROM p_spjcxx_sz_fd AS fd,p_spjcxx_sz AS sz 
WHERE fd.bm=sz.bm AND sz.lbbm NOT IN('050201','050301','050302','050401','050502') 
 AND sz.lbbm NOT LIKE '0310%' 
 AND fd.lsj>2.4 
 AND fd.cbj IS NOT NULL
 AND sz.is_kb<>1
ORDER BY fd.bm;
--���������




WHILE EXISTS(SELECT bm FROM @tb_temp_ppc)
BEGIN
   SET ROWCOUNT 1
   SELECT @bm=bm,@cbj=cbj,@lsj=lsj FROM @tb_temp_ppc;
--��������
   SET @lilv=(@lsj-@cbj)/@lsj;
   IF (@lilv>=0.773 AND @lilv<1)
      BEGIN
       SET @buyNum=2
      END
   ELSE IF(@lilv>=0.58)
       BEGIN
        SET @buyNum=3
      END
   ELSE IF(@lilv>=0.464)
       BEGIN
        SET @buyNum=4
       END
   ELSE IF(@lilv>=0.387)
       BEGIN
        SET @buyNum=5
       END
   ELSE IF(@lilv>=0.331)
       BEGIN
        SET @buyNum=6
       END
   ELSE IF(@lilv>=0.29)
       BEGIN
        SET @buyNum=7
       END
   ELSE IF(@lilv>=0.258)
       BEGIN
        SET @buyNum=8
       END
   ELSE
       BEGIN
        SET @buyNum=0
       END
       
   --����Ʒ��    
   IF (@buyNum<>0)
       BEGIN
        SET @hyj=(SELECT CASE WHEN dm='001' THEN fhyr_sj ELSE hyr_sj END FROM ls_spsj WHERE spbm=@bm AND lbbm='000001');
        IF(@hyj IS NOT NULL)
         BEGIN
          SET @avgsj=@lsj*@buyNum/(@buyNum+1);--��Ա�۲�Ϊ��ʱ����������
         END
         --��Ա��Ϊ�ջ���ƽ���ۼ۵������ۼ�ʱ������Ʒ��
         IF (@hyj IS NULL OR @avgsj<@hyj)
           BEGIN
            SET @oldname=( SELECT CASE WHEN CHARINDEX('��',mc)=0 THEN mc ELSE SUBSTRING(mc,1,CHARINDEX('��',mc)-1) END from p_spjcxx_sz WHERE bm=@bm);
             IF (@oldname IS NOT NULL)
               BEGIN
                    UPDATE p_spjcxx_sz SET mc=@oldname+'��'+ cast(@buynum as varchar(50)) +'+1' WHERE bm=@bm;
               END
           END
       END      
   SET ROWCOUNT 0       
   DELETE FROM @tb_temp_ppc WHERE bm=@bm;        
   END
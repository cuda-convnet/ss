/*������Ʒʹ����*/
ALTER TABLE T_GiftStockOut ADD IntUsedID BIGINT NOT NULL DEFAULT 1
UPDATE T_GiftStockOut SET IntUsedID=UserId
/*���Ӳͷ�ʹ����*/
ALTER TABLE T_Meals ADD IntUsedID BIGINT NOT NULL DEFAULT 1
UPDATE T_Meals SET IntUsedID=UserId
﻿CREATE PROCEDURE FI_SP_ExcluirBeneficiarios
@ID BIGINT
AS
BEGIN
	DELETE FROM BENEFICIARIOS WHERE IDCLIENTE = @ID
END
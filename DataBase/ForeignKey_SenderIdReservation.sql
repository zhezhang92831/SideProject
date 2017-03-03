ALTER TABLE [dbo].[ReservationRequest]
	ADD CONSTRAINT [ForeignKey_SenderIdReservation]
	FOREIGN KEY (SenderId)
	REFERENCES [Parent] (Id)

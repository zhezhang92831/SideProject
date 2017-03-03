ALTER TABLE [dbo].[ReservationRequest]
	ADD CONSTRAINT [ForeignKey_ReceiverIdReservation]
	FOREIGN KEY (ReceiverId)
	REFERENCES [CareGiver] (Id)
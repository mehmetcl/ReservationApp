select * from Reservation
SELECT R.id, R.ReservationDate, T.TableName FROM Reservation R JOIN Tables T ON R.id = T.id
SELECT R.id, R.[table id], R.[date], R.reservationname, R.description, T.id , T.[name]  FROM Reservation R JOIN [Tables] T ON R.[table id] = T.id

--Incorporate all the existing movie booking features of bookmyshow, --> create a the schema in database and insert the records.

CREATE TABLE user_table (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    location NVARCHAR(100)
);

CREATE TABLE theatre_table (
    theatre_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    location NVARCHAR(100) NOT NULL
);

CREATE TABLE movies_table (
    movie_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    genre NVARCHAR(50),
    description NVARCHAR(MAX)
);

CREATE TABLE screens_table (
    screen_id INT PRIMARY KEY IDENTITY(1,1),
    theatre_id INT,
    name NVARCHAR(50) NOT NULL,
    capacity INT NOT NULL,
    CONSTRAINT FK_screens_theatre FOREIGN KEY (theatre_id) REFERENCES theatre_table(theatre_id)
);

CREATE TABLE shows_table (
    show_id INT PRIMARY KEY IDENTITY(1,1),
    movie_id INT,
    screen_id INT,
    show_date DATE NOT NULL,
    show_time TIME NOT NULL,
    language NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_shows_movie FOREIGN KEY (movie_id) REFERENCES movies_table(movie_id),
    CONSTRAINT FK_shows_screen FOREIGN KEY (screen_id) REFERENCES screens_table(screen_id)
);

CREATE TABLE seat_table (
    seat_id INT PRIMARY KEY IDENTITY(1,1),
    screen_id INT,
    seat_name NVARCHAR(10) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_seat_screen FOREIGN KEY (screen_id) REFERENCES screens_table(screen_id)
);

CREATE TABLE bookings_table (
    book_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    show_id INT,
    booking_date DATETIME2 NOT NULL,
    CONSTRAINT FK_bookings_user FOREIGN KEY (user_id) REFERENCES user_table(user_id),
    CONSTRAINT FK_bookings_show FOREIGN KEY (show_id) REFERENCES shows_table(show_id)
);

CREATE TABLE booked_seats (
    booked_seat_id INT PRIMARY KEY IDENTITY(1,1),
    book_id INT,
    seat_id INT,
    show_id INT,
    CONSTRAINT FK_booked_seats_booking FOREIGN KEY (book_id) REFERENCES bookings_table(book_id),
    CONSTRAINT FK_booked_seats_seat FOREIGN KEY (seat_id) REFERENCES seat_table(seat_id),
    CONSTRAINT FK_booked_seats_show FOREIGN KEY (show_id) REFERENCES shows_table(show_id)
);

CREATE TABLE payments_table (
    payment_id INT PRIMARY KEY IDENTITY(1,1),
    book_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    status NVARCHAR(20) NOT NULL,
    method NVARCHAR(50),
    payment_date DATETIME2 NOT NULL,
    CONSTRAINT FK_payments_booking FOREIGN KEY (book_id) REFERENCES bookings_table(book_id),
    CONSTRAINT CHK_status CHECK (status IN ('Pending', 'Completed', 'Failed'))
);

CREATE UNIQUE NONCLUSTERED INDEX idx_unique_seat_per_show
ON booked_seats (seat_id, show_id);


------------Data Insertion-----------

INSERT INTO user_table (name, email, location)
VALUES 
    (N'User1', N'user1@gmail.com', N'Kochi'),
    (N'User2', N'user2@gmail.com', N'Trivandrum');

INSERT INTO theatre_table (name, location)
VALUES 
    (N'PVR Cinemas Lulu Mall', N'Trivandrum'),
    (N'Cinepolis Centre Square Mall', N'Kochi'),
    (N'PVR Cinemas Lulu Mall', N'Kochi');

INSERT INTO movies_table (name, genre, description)
VALUES 
    (N'Empuraan', N'Action Thriller', N'Mohanlal in a high-octane sequel to Lucifer, blending crime and drama.'),
    (N'Manjummel Boys', N'Thriller Drama', N'A gripping survival story based on true events in the Guna Caves.'),
    (N'Thudarum', N'Action Adventure', N'An epic tale of resilience and heroism in a disaster scenario.'),
    (N'2018', N'Drama Disaster', N'Based on the 2018 Kerala floods, a story of human spirit and unity.'),
    (N'Aadujeevitham', N'Survival Drama', N'Prithviraj in a poignant adaptation of Benyamin''s novel about a migrant worker.'),
    (N'Aavesham', N'Action Comedy', N'A hilarious yet action-packed tale of college freshers and a mysterious "uncle".'),
    (N'Pulimurugan', N'Action Adventure', N'Mohanlal as a tiger hunter in a visually stunning forest adventure.'),
    (N'Premalu', N'Romantic Comedy', N'A light-hearted rom-com exploring modern relationships and heartbreak.'),
    (N'Lucifer', N'Political Thriller', N'Mohanlal''s iconic role as Stephen Nedumpally in a power-packed drama.'),
    (N'Bheeshma Parvam', N'Action Family Drama', N'A sequel to the 1989 classic, with Mammootty in a mass entertainer.');

INSERT INTO screens_table (theatre_id, name, capacity)
VALUES 
    (1, N'Screen 1', 250), (1, N'Screen 2', 200),
    (2, N'Screen 1', 180), (2, N'Screen 2', 150),
    (3, N'Screen 1', 300), (3, N'Screen 2', 250);

INSERT INTO shows_table (movie_id, screen_id, show_date, show_time, language)
VALUES 
    (1, 1, '2025-10-30', '14:00', N'Malayalam'),
    (1, 3, '2025-10-30', '18:00', N'Malayalam'),
    (2, 2, '2025-10-30', '15:30', N'Malayalam'),
    (2, 4, '2025-10-30', '19:30', N'Malayalam'),
    (3, 1, '2025-10-31', '12:00', N'Malayalam'),
    (3, 3, '2025-10-31', '16:00', N'Malayalam'),
    (4, 2, '2025-10-31', '13:30', N'Malayalam'),
    (4, 4, '2025-10-31', '17:30', N'Malayalam'),
    (5, 1, '2025-10-30', '11:00', N'Malayalam'),
    (5, 3, '2025-10-30', '20:00', N'Malayalam'),
    (6, 2, '2025-10-31', '10:30', N'Malayalam'),
    (6, 4, '2025-10-31', '14:30', N'Malayalam'),
    (7, 1, '2025-10-30', '16:30', N'Malayalam'),
    (7, 3, '2025-10-30', '21:00', N'Malayalam'),
    (8, 2, '2025-10-31', '18:00', N'Malayalam'),
    (8, 4, '2025-10-31', '22:00', N'Malayalam'),
    (9, 1, '2025-10-30', '20:30', N'Malayalam'),
    (9, 3, '2025-10-31', '10:00', N'Malayalam'),
    (10, 2, '2025-10-30', '22:00', N'Malayalam'),
    (10, 4, '2025-10-31', '12:30', N'Malayalam');

INSERT INTO seat_table (screen_id, seat_name, price)
VALUES 
    (1, N'A1', 200.00), (1, N'A2', 200.00), (1, N'B1', 200.00), (1, N'B2', 200.00), (1, N'C1', 300.00),
    (1, N'C2', 300.00), (1, N'D1', 200.00), (1, N'D2', 200.00), (1, N'E1', 300.00), (1, N'E2', 300.00),
    (2, N'A1', 200.00), (2, N'A2', 200.00), (2, N'B1', 200.00), (2, N'B2', 200.00), (2, N'C1', 300.00),
    (2, N'C2', 300.00), (2, N'D1', 200.00), (2, N'D2', 200.00), (2, N'E1', 300.00), (2, N'E2', 300.00),
    (3, N'A1', 200.00), (3, N'A2', 200.00), (3, N'B1', 200.00), (3, N'B2', 200.00), (3, N'C1', 300.00),
    (3, N'C2', 300.00), (3, N'D1', 200.00), (3, N'D2', 200.00), (3, N'E1', 300.00), (3, N'E2', 300.00),
    (4, N'A1', 200.00), (4, N'A2', 200.00), (4, N'B1', 200.00), (4, N'B2', 200.00), (4, N'C1', 300.00),
    (4, N'C2', 300.00), (4, N'D1', 200.00), (4, N'D2', 200.00), (4, N'E1', 300.00), (4, N'E2', 300.00),
    (5, N'A1', 200.00), (5, N'A2', 200.00), (5, N'B1', 200.00), (5, N'B2', 200.00), (5, N'C1', 300.00),
    (5, N'C2', 300.00), (5, N'D1', 200.00), (5, N'D2', 200.00), (5, N'E1', 300.00), (5, N'E2', 300.00),
    (6, N'A1', 200.00), (6, N'A2', 200.00), (6, N'B1', 200.00), (6, N'B2', 200.00), (6, N'C1', 300.00),
    (6, N'C2', 300.00), (6, N'D1', 200.00), (6, N'D2', 200.00), (6, N'E1', 300.00), (6, N'E2', 300.00);

INSERT INTO bookings_table (user_id, show_id, booking_date)
VALUES 
    (1, 1, '2025-10-29 15:00:00'),
    (1, 3, '2025-10-29 15:30:00'),
    (2, 9, '2025-10-29 16:00:00');

INSERT INTO booked_seats (book_id, seat_id, show_id)
VALUES 
    (1, 1, 1), (1, 2, 1),
    (2, 11, 3), (2, 12, 3),
    (3, 3, 9), (3, 4, 9);

INSERT INTO payments_table (book_id, amount, status, method, payment_date)
VALUES 
    (1, 400.00, N'Completed', N'UPI', '2025-10-29 15:01:00'),
    (2, 400.00, N'Pending', N'Credit Card', '2025-10-29 15:31:00'),
    (3, 400.00, N'Completed', N'Cash', '2025-10-29 16:01:00');
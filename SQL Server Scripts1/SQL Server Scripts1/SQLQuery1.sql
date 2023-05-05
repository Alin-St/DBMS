use dbms;

DROP TABLE Tickets;
DROP TABLE Festival_Attendees;
DROP TABLE Attendees;
DROP TABLE Schedule;
DROP TABLE Festival_Stages;
DROP TABLE Stages;
DROP TABLE Festival_Artists;
DROP TABLE Artists;
DROP TABLE Venues;
DROP TABLE Festivals;
DROP TABLE Locations;

CREATE TABLE Locations (
    location_id INT IDENTITY(1,1) PRIMARY KEY,
    location_name VARCHAR(255) NOT NULL,
    city VARCHAR(255) NOT NULL,
    state VARCHAR(255) NOT NULL,
    country VARCHAR(255) NOT NULL
);

CREATE TABLE Festivals (
    festival_id INT IDENTITY(1,1) PRIMARY KEY,
    festival_name VARCHAR(255) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    location_id INT NOT NULL,
    FOREIGN KEY (location_id) REFERENCES Locations(location_id)
);

CREATE TABLE Venues (
    venue_id INT IDENTITY(1,1) PRIMARY KEY,
    venue_name VARCHAR(255) NOT NULL,
    location_id INT NOT NULL,
    FOREIGN KEY (location_id) REFERENCES Locations(location_id)
);

CREATE TABLE Artists (
    artist_id INT IDENTITY(1,1) PRIMARY KEY,
    artist_name VARCHAR(255) NOT NULL,
    genre VARCHAR(255) NOT NULL
);

CREATE TABLE Festival_Artists (
    festival_id INT NOT NULL,
    artist_id INT NOT NULL,
    PRIMARY KEY (festival_id, artist_id),
    FOREIGN KEY (festival_id) REFERENCES Festivals(festival_id),
    FOREIGN KEY (artist_id) REFERENCES Artists(artist_id)
);

CREATE TABLE Stages (
    stage_id INT IDENTITY(1,1) PRIMARY KEY,
    stage_name VARCHAR(255) NOT NULL,
    venue_id INT NOT NULL,
    FOREIGN KEY (venue_id) REFERENCES Venues(venue_id)
);

CREATE TABLE Festival_Stages (
    festival_id INT NOT NULL,
    stage_id INT NOT NULL,
    PRIMARY KEY (festival_id, stage_id),
    FOREIGN KEY (festival_id) REFERENCES Festivals(festival_id),
    FOREIGN KEY (stage_id) REFERENCES Stages(stage_id)
);

CREATE TABLE Schedule (
    schedule_id INT IDENTITY(1,1) PRIMARY KEY,
    festival_id INT NOT NULL,
    stage_id INT NOT NULL,
    start_time DATETIME NOT NULL,
    end_time DATETIME NOT NULL,
    artist_id INT NOT NULL,
    FOREIGN KEY (festival_id) REFERENCES Festivals(festival_id),
    FOREIGN KEY (stage_id) REFERENCES Stages(stage_id),
    FOREIGN KEY (artist_id) REFERENCES Artists(artist_id)
);

CREATE TABLE Attendees (
    attendee_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL
);

CREATE TABLE Festival_Attendees (
    festival_id INT NOT NULL,
    attendee_id INT NOT NULL,
    PRIMARY KEY (festival_id, attendee_id),
    FOREIGN KEY (festival_id) REFERENCES Festivals(festival_id),
    FOREIGN KEY (attendee_id) REFERENCES Attendees(attendee_id)
);

CREATE TABLE Tickets (
    ticket_id INT IDENTITY(1,1) PRIMARY KEY,
    ticket_type VARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    festival_id INT NOT NULL,
    attendee_id INT NOT NULL,
    FOREIGN KEY (festival_id) REFERENCES Festivals(festival_id),
    FOREIGN KEY (attendee_id) REFERENCES Attendees(attendee_id)
);

INSERT INTO Locations (location_name, city, state, country)
VALUES
('Empire Polo Club', 'Indio', 'California', 'USA'),
('Grant Park', 'Chicago', 'Illinois', 'USA');

INSERT INTO Festivals (festival_name, start_date, end_date, location_id)
VALUES
('Coachella', '2023-04-14', '2023-04-16', 1),
('Lollapalooza', '2023-08-03', '2023-08-06', 2);

INSERT INTO Venues (venue_name, location_id)
VALUES
('Coachella Main Stage', 1),
('Bud Light Stage', 2);

INSERT INTO Artists (artist_name, genre)
VALUES
('Billie Eilish', 'Pop'),
('Kendrick Lamar', 'Hip hop');

INSERT INTO Festival_Artists (festival_id, artist_id)
VALUES
(1, 1),
(2, 2);

INSERT INTO Stages (stage_name, venue_id)
VALUES
('Coachella Outdoor Theatre', 1),
('T-Mobile Stage', 2);

INSERT INTO Festival_Stages (festival_id, stage_id)
VALUES
(1, 1),
(2, 2);

INSERT INTO Schedule (festival_id, stage_id, start_time, end_time, artist_id)
VALUES
(1, 1, '2023-04-14 20:00:00', '2023-04-14 22:00:00', 1),
(2, 2, '2023-08-03 19:30:00', '2023-08-03 21:00:00', 2);

INSERT INTO Attendees (first_name, last_name, email)
VALUES
('John', 'Doe', 'johndoe@gmail.com'),
('Jane', 'Smith', 'janesmith@yahoo.com');

INSERT INTO Festival_Attendees (festival_id, attendee_id)
VALUES
(1, 1),
(2, 2);

INSERT INTO Tickets (ticket_type, price, festival_id, attendee_id)
VALUES
('General Admission', 250.00, 1, 1),
('VIP', 500.00, 2, 2);


-- More Locations + Festivals:
INSERT INTO Locations (location_name, city, state, country)
VALUES
    ('Central Park', 'New York', 'NY', 'USA'),
    ('Hyde Park', 'London', '', 'England'),
    ('Parc des Princes', 'Paris', '', 'France'),
    ('Yoyogi Park', 'Tokyo', '', 'Japan'),
    ('Royal Botanic Gardens', 'Sydney', 'NSW', 'Australia');

	INSERT INTO Festivals (festival_name, start_date, end_date, location_id)
VALUES
    ('Central Park SummerStage', '2023-06-01', '2023-09-30', 3),
    ('Shakespeare in the Park', '2023-05-01', '2023-09-30', 3),
    ('Summer Music Festival', '2023-06-15', '2023-06-30', 3),
    ('British Summer Time', '2023-07-05', '2023-07-09', 4),
    ('Wireless Festival', '2023-06-30', '2023-07-02', 4),
    ('Paris Jazz Festival', '2023-06-01', '2023-07-31', 4),
    ('Bastille Day', '2023-07-14', '2023-07-14', 5),
    ('Tokyo Jazz Festival', '2023-08-31', '2023-09-03', 5),
    ('Yoyogi Oedo Matsuri', '2023-10-14', '2023-10-15', 5),
    ('Sydney Festival', '2023-01-06', '2023-01-28', 6),
    ('Vivid Sydney', '2023-05-26', '2023-06-17', 6),
    ('Royal Easter Show', '2023-04-06', '2023-04-19', 6);


SELECT * FROM Locations;
SELECT * FROM Festivals;
SELECT * FROM Venues;
SELECT * FROM Artists;
SELECT * FROM Festival_Artists;
SELECT * FROM Stages;
SELECT * FROM Festival_Stages;
SELECT * FROM Schedule;
SELECT * FROM Attendees;
SELECT * FROM Festival_Attendees;
SELECT * FROM Tickets;

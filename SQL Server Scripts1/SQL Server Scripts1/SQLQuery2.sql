use dbms;

CREATE TABLE Albums (
  idA int PRIMARY KEY,
  album_title varchar(255),
  artist varchar(255),
  release_year int
);

CREATE TABLE Songs (
  idS int PRIMARY KEY,
  idA int FOREIGN KEY REFERENCES Albums(idA),
  title varchar(255),
  duration int,
  track_number int
);

INSERT INTO Albums (idA, album_title, artist, release_year)
VALUES 
  (1, 'The Dark Side of the Moon', 'Pink Floyd', 1973),
  (2, 'Thriller', 'Michael Jackson', 1982),
  (3, 'Abbey Road', 'The Beatles', 1969),
  (4, 'Back in Black', 'AC/DC', 1980),
  (5, 'Led Zeppelin IV', 'Led Zeppelin', 1971),
  (6, 'The Eminem Show', 'Eminem', 2002),
  (7, 'Born to Run', 'Bruce Springsteen', 1975),
  (8, 'Nevermind', 'Nirvana', 1991),
  (9, 'A Night at the Opera', 'Queen', 1975),
  (10, 'Hotel California', 'The Eagles', 1976);

INSERT INTO Songs (idS, idA, title, duration, track_number)
VALUES 
  (1, 1, 'Speak to Me', 67, 1),
  (2, 1, 'Breathe', 163, 2),
  (3, 1, 'On the Run', 216, 3),
  (4, 1, 'Time', 418, 4),
  (5, 1, 'The Great Gig in the Sky', 277, 5),
  (6, 2, 'Wanna Be Startin'' Somethin''', 370, 1),
  (7, 2, 'Baby Be Mine', 255, 2),
  (8, 2, 'The Girl Is Mine', 223, 3),
  (9, 2, 'Thriller', 357, 4),
  (10, 2, 'Beat It', 258, 5);


select * from Albums;
select * from Songs;

drop table Songs;
drop table Albums;

CREATE TABLE Studio (
  idStudio INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR(90)    ,
  AnimationStyle VARCHAR(90)      ,
PRIMARY KEY(idStudio));
GO




CREATE TABLE User_2 (
  idUser_2 INTEGER  NOT NULL   IDENTITY ,
  username VARCHAR(50)    ,
  password_2 VARCHAR(50)    ,
  type_2 INTEGER      ,
PRIMARY KEY(idUser_2));
GO




CREATE TABLE Genre (
  idGenre INTEGER  NOT NULL   IDENTITY ,
  Type_2 VARCHAR(30)      ,
PRIMARY KEY(idGenre));
GO




CREATE TABLE WatchList (
  idWatchList INTEGER  NOT NULL   IDENTITY ,
  User_2_idUser_2 INTEGER  NOT NULL  ,
  WatchListName VARCHAR(500)      ,
PRIMARY KEY(idWatchList)  ,
  FOREIGN KEY(User_2_idUser_2)
    REFERENCES User_2(idUser_2));
GO


CREATE INDEX WatchList_FKIndex1 ON WatchList (User_2_idUser_2);
GO


CREATE INDEX IFK_Rel_02 ON WatchList (User_2_idUser_2);
GO


CREATE TABLE MovieSeries (
  idMovies INTEGER  NOT NULL   IDENTITY ,
  Genre_idGenre INTEGER  NOT NULL  ,
  Name VARCHAR(90)    ,
  Plot VARCHAR(500)    ,
  Dubbed BIT      ,
PRIMARY KEY(idMovies)  ,
  FOREIGN KEY(Genre_idGenre)
    REFERENCES Genre(idGenre));
GO


CREATE INDEX MovieSeries_FKIndex1 ON MovieSeries (Genre_idGenre);
GO


CREATE INDEX IFK_Rel_14 ON MovieSeries (Genre_idGenre);
GO


CREATE TABLE Series (
  idShow INTEGER  NOT NULL  ,
  Genre_idGenre INTEGER  NOT NULL  ,
  Studio_idStudio INTEGER  NOT NULL  ,
  Name VARCHAR(90)    ,
  Plot VARCHAR(500)    ,
  Status_2 BIT    ,
  Dubbed BIT    ,
  NumberOfEpisodes INTEGER    ,
  NumberOfSeasons INTEGER    ,
  SeasnTime VARCHAR(50)      ,
PRIMARY KEY(idShow)    ,
  FOREIGN KEY(Studio_idStudio)
    REFERENCES Studio(idStudio),
  FOREIGN KEY(Genre_idGenre)
    REFERENCES Genre(idGenre));
GO


CREATE INDEX Show_2_FKIndex3 ON Series (Studio_idStudio);
GO
CREATE INDEX Series_FKIndex3 ON Series (Genre_idGenre);
GO


CREATE INDEX IFK_Rel_24 ON Series (Studio_idStudio);
GO
CREATE INDEX IFK_Rel_14 ON Series (Genre_idGenre);
GO


CREATE TABLE Part (
  idPart INTEGER  NOT NULL   IDENTITY ,
  MovieSeries_idMovies INTEGER  NOT NULL  ,
  Number INTEGER    ,
  Duration VARCHAR(50)      ,
PRIMARY KEY(idPart)  ,
  FOREIGN KEY(MovieSeries_idMovies)
    REFERENCES MovieSeries(idMovies));
GO


CREATE INDEX Part_FKIndex1 ON Part (MovieSeries_idMovies);
GO


CREATE INDEX IFK_Rel_13 ON Part (MovieSeries_idMovies);
GO


CREATE TABLE Watchlist_has_Part (
  Part_idPart INTEGER  NOT NULL  ,
  WatchList_idWatchList INTEGER  NOT NULL    ,
PRIMARY KEY(Part_idPart, WatchList_idWatchList)    ,
  FOREIGN KEY(Part_idPart)
    REFERENCES Part(idPart),
  FOREIGN KEY(WatchList_idWatchList)
    REFERENCES WatchList(idWatchList));
GO


CREATE INDEX Part_has_WatchList_FKIndex1 ON Watchlist_has_Part (Part_idPart);
GO
CREATE INDEX Part_has_WatchList_FKIndex2 ON Watchlist_has_Part (WatchList_idWatchList);
GO


CREATE INDEX IFK_Rel_13 ON Watchlist_has_Part (Part_idPart);
GO
CREATE INDEX IFK_Rel_14 ON Watchlist_has_Part (WatchList_idWatchList);
GO


CREATE TABLE WatchList_has_Anime (
  WatchList_idWatchList INTEGER  NOT NULL  ,
  Series_idShow INTEGER  NOT NULL    ,
PRIMARY KEY(WatchList_idWatchList, Series_idShow)    ,
  FOREIGN KEY(WatchList_idWatchList)
    REFERENCES WatchList(idWatchList),
  FOREIGN KEY(Series_idShow)
    REFERENCES Series(idShow));
GO


CREATE INDEX WatchList_has_Anime_FKIndex1 ON WatchList_has_Anime (WatchList_idWatchList);
GO
CREATE INDEX WatchList_has_Anime_FKIndex2 ON WatchList_has_Anime (Series_idShow);
GO


CREATE INDEX IFK_Rel_11 ON WatchList_has_Anime (WatchList_idWatchList);
GO
CREATE INDEX IFK_Rel_12 ON WatchList_has_Anime (Series_idShow);
GO




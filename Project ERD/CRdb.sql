CREATE TABLE SeasonTime (
  idCategory INTEGER  NOT NULL   IDENTITY ,
  Type_2 VARCHAR      ,
PRIMARY KEY(idCategory));
GO




CREATE TABLE Studio (
  idStudio INTEGER  NOT NULL   IDENTITY ,
  Name VARCHAR    ,
  Animation Style VARCHAR      ,
PRIMARY KEY(idStudio));
GO




CREATE TABLE User_2 (
  idUser_2 INTEGER  NOT NULL   IDENTITY ,
  Rank INT      ,
PRIMARY KEY(idUser_2));
GO




CREATE TABLE Genre (
  idGenre INTEGER  NOT NULL   IDENTITY ,
  Type_2 VARCHAR      ,
PRIMARY KEY(idGenre));
GO




CREATE TABLE WatchList (
  idWatchList INTEGER  NOT NULL   IDENTITY ,
  User_2_idUser_2 INTEGER  NOT NULL  ,
  WatchListName VARCHAR      ,
PRIMARY KEY(idWatchList)  ,
  FOREIGN KEY(User_2_idUser_2)
    REFERENCES User_2(idUser_2));
GO


CREATE INDEX WatchList_FKIndex1 ON WatchList (User_2_idUser_2);
GO


CREATE INDEX IFK_Rel_02 ON WatchList (User_2_idUser_2);
GO


CREATE TABLE Movie Series (
  idMovies INTEGER  NOT NULL   IDENTITY ,
  Genre_idGenre INTEGER  NOT NULL  ,
  Name VARCHAR    ,
  Plot VARCHAR    ,
  Dubbed BOOL      ,
PRIMARY KEY(idMovies)  ,
  FOREIGN KEY(Genre_idGenre)
    REFERENCES Genre(idGenre));
GO


CREATE INDEX Movie Series_FKIndex1 ON Movie Series (Genre_idGenre);
GO


CREATE INDEX IFK_Rel_14 ON Movie Series (Genre_idGenre);
GO


CREATE TABLE Part (
  idPasrt INTEGER  NOT NULL   IDENTITY ,
  Movie Series_idMovies INTEGER  NOT NULL  ,
  Number INTEGER    ,
  Duration TIME      ,
PRIMARY KEY(idPasrt)  ,
  FOREIGN KEY(Movie Series_idMovies)
    REFERENCES Movie Series(idMovies));
GO


CREATE INDEX Part_FKIndex1 ON Part (Movie Series_idMovies);
GO


CREATE INDEX IFK_Rel_13 ON Part (Movie Series_idMovies);
GO


CREATE TABLE Movie Series_has_WatchList (
  Movie Series_idMovies INTEGER  NOT NULL  ,
  WatchList_idWatchList INTEGER  NOT NULL    ,
PRIMARY KEY(Movie Series_idMovies, WatchList_idWatchList)    ,
  FOREIGN KEY(Movie Series_idMovies)
    REFERENCES Movie Series(idMovies),
  FOREIGN KEY(WatchList_idWatchList)
    REFERENCES WatchList(idWatchList));
GO


CREATE INDEX Movie Series_has_WatchList_FKIndex1 ON Movie Series_has_WatchList (Movie Series_idMovies);
GO
CREATE INDEX Movie Series_has_WatchList_FKIndex2 ON Movie Series_has_WatchList (WatchList_idWatchList);
GO


CREATE INDEX IFK_Rel_13 ON Movie Series_has_WatchList (Movie Series_idMovies);
GO
CREATE INDEX IFK_Rel_14 ON Movie Series_has_WatchList (WatchList_idWatchList);
GO


CREATE TABLE Series (
  idShow INTEGER  NOT NULL   IDENTITY ,
  Studio_idStudio INTEGER  NOT NULL  ,
  SeasonTime_idCategory INTEGER  NOT NULL  ,
  Name VARCHAR    ,
  Plot VARCHAR    ,
  Status_2 VARCHAR    ,
  Dubbed BOOL      ,
PRIMARY KEY(idShow)    ,
  FOREIGN KEY(SeasonTime_idCategory)
    REFERENCES SeasonTime(idCategory),
  FOREIGN KEY(Studio_idStudio)
    REFERENCES Studio(idStudio));
GO


CREATE INDEX Anime_FKIndex1 ON Series (SeasonTime_idCategory);
GO
CREATE INDEX Show_2_FKIndex3 ON Series (Studio_idStudio);
GO


CREATE INDEX IFK_Rel_13 ON Series (SeasonTime_idCategory);
GO
CREATE INDEX IFK_Rel_24 ON Series (Studio_idStudio);
GO


CREATE TABLE Show_2_has_Genre (
  Series_idShow INTEGER  NOT NULL  ,
  Genre_idGenre INTEGER  NOT NULL    ,
PRIMARY KEY(Series_idShow, Genre_idGenre)    ,
  FOREIGN KEY(Series_idShow)
    REFERENCES Series(idShow),
  FOREIGN KEY(Genre_idGenre)
    REFERENCES Genre(idGenre));
GO


CREATE INDEX Show_2_has_Genre_FKIndex1 ON Show_2_has_Genre (Series_idShow);
GO
CREATE INDEX Show_2_has_Genre_FKIndex2 ON Show_2_has_Genre (Genre_idGenre);
GO


CREATE INDEX IFK_Rel_20 ON Show_2_has_Genre (Series_idShow);
GO
CREATE INDEX IFK_Rel_21 ON Show_2_has_Genre (Genre_idGenre);
GO


CREATE TABLE Season (
  idSeason INTEGER  NOT NULL   IDENTITY ,
  Series_idShow INTEGER  NOT NULL  ,
  Number INTEGER      ,
PRIMARY KEY(idSeason)  ,
  FOREIGN KEY(Series_idShow)
    REFERENCES Series(idShow));
GO


CREATE INDEX Season_FKIndex1 ON Season (Series_idShow);
GO


CREATE INDEX IFK_Rel_16 ON Season (Series_idShow);
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


CREATE TABLE Episode (
  idEpisode INTEGER  NOT NULL  ,
  Season_idSeason INTEGER    ,
  Number INTEGER      ,
PRIMARY KEY(idEpisode)  ,
  FOREIGN KEY(Season_idSeason)
    REFERENCES Season(idSeason));
GO


CREATE INDEX Episode_FKIndex1 ON Episode (Season_idSeason);
GO


CREATE INDEX IFK_Rel_15 ON Episode (Season_idSeason);
GO




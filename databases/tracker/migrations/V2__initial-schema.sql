CREATE TABLE time_entries_1 (
  id         BIGINT(20) NOT NULL AUTO_INCREMENT,
  project_id BIGINT(20),
  user_id    BIGINT(20),
  date       DATE,
  hours      INT,

  PRIMARY KEY (id)
);
CREATE TABLE time_entries_2 (
  id         BIGINT(20) NOT NULL AUTO_INCREMENT,
  project_id BIGINT(20),
  user_id    BIGINT(20),
  date       DATE,
  hours      INT,

  PRIMARY KEY (id)
)
  ENGINE = innodb
  DEFAULT CHARSET = utf8;
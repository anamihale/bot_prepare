DROP TABLE banks;
DROP TABLE synonyms;
DROP TABLE subscriptions;
DROP TABLE norms;
CREATE TABLE banks (
  id INT,
  name VARCHAR(254)
);
CREATE TABLE synonyms (
  name VARCHAR(254),
  id INT
);
CREATE TABLE subscriptions (
  user_id INT,
  bank_id INT
);
CREATE TABLE norms (
  id INT,
  norm VARCHAR(10),
  value FLOAT,
  date DATE
);

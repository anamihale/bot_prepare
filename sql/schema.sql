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
CREATE TABLE norm_values (
  id INT,
  norm VARCHAR(10),
  value FLOAT,
  date DATE
);
CREATE TABLE norms (
  data DATE,
  norm VARCHAR(10),
  value FLOAT,
  type VARCHAR(3)
)
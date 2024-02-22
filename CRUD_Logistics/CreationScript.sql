create database test_db;

use test_db;

CREATE TABLE job (
    id int AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    employee_num INT DEFAULT 0,
    PRIMARY KEY (id, name)
);

insert into job(name) values ('developer');
insert into job(name) values ('test');
insert into job(name) values ('engineer');
insert into job(name) values ('medical doctor');
insert into job(name) values ('police officer');

CREATE TABLE people (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    age INT,
    job INT not null,
    jobTitle varchar(255),
    FOREIGN KEY (job,jobTitle) REFERENCES job(id, name) ON UPDATE CASCADE
);

insert into people(name, age, job, jobTitle) values ('test', 10, 4, 'test');
insert into people(name, age, job, jobTitle) values ('Neko', 20, 2, 'engineer');
insert into people(name, age, job, jobTitle) values ('Pera', 35, 3, 'medical doctor');
insert into people(name, age, job, jobTitle) values ('Milica', 23, 1, 'developer');
insert into people(name, age, job, jobTitle) values ('Zika', 47, 5, 'policeman');

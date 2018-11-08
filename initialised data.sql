
CREATE TABLE Outlets (
	otID	INTEGER PRIMARY KEY NOT NULL,
	otAddress TEXT NOT NULL,
	otName	TEXT NOT NULL
	
);


CREATE TABLE user (
	userId	INTEGER PRIMARY KEY NOT NULL,
	user_name	TEXT DEFAULT '',
	carNo	TEXT DEFAULT '',
	user_password	TEXT NOT NULL,
	identity	TEXT DEFAULT '',
	Outlet	INTEGER,
	FOREIGN KEY(Outlet) REFERENCES Outlet(otID)
);


CREATE TABLE jobs (
	id	INTEGER PRIMARY KEY NOT NULL,
	closedate TEXT DEFAULT '',
	createdate	TEXT NOT NULL,
	carNo	TEXT DEFAULT '',
	desk	INTEGER,
	manager	INTEGER,
	worker	INTEGER,
	jobDescription	TEXT DEFAULT '',
	resolve	INTEGER,
	priority INTEGER,
	comment	 TEXT DEFAULT '',
	outlet INTEGER,
	customer INTEGER,
	jobStatus INTEGER,
	opendate TEXT DEFAULT '',
	assigndate TEXT DEFAULT '',
	jobType TEXT DEFAULT '',
	jobHistory TEXT DEFAULT '',
	FOREIGN KEY(customer) REFERENCES user(userId),
	FOREIGN KEY(worker) REFERENCES user(userId),
	FOREIGN KEY(manager) REFERENCES user(userId),
	FOREIGN KEY(desk) REFERENCES user(userId),
	FOREIGN KEY(outlet) REFERENCES Outlets(otID)
);



-- add outlets;
INSERT INTO Outlets (otAddress, otName) VALUES ('Albany', 'Albany');
INSERT INTO Outlets (otAddress, otName) VALUES ('Glenfield', 'Glenfield');
INSERT INTO Outlets (otAddress, otName) VALUES ('BrownsBay', 'BrownsBay');
INSERT INTO Outlets (otAddress, otName) VALUES ('NorthShore', 'NorthShore');


--add users;
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('manager1','8585ss','123','manager',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('desk1','AE86','123','hpdesk',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('desk2','AE86','123','hpdesk',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('desk3','AE86','123','hpdesk',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('desk4','AE86','123','hpdesk',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('worker1','75214aa','123','work',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('worker2','8585ss','123','work',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('worker3','8585ss','123','work',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('worker4','8585ss','123','work',1);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('userA','HTZ123','123','user',NULL);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('userB','XXX111','123','user',NULL);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('userC','YYY123','123','user',NULL);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('userD','ZZZ345','r123','user',NULL);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('userE','AAA123','r123','user',NULL);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('desk22',' ','123','hpdesk',2);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('worker22',' ','123','work',2);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('manager2','HTZ123','123','manager',2);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('manager3','HTZ123','123','manager',3);
INSERT INTO user(user_name,carNo,user_password,identity,Outlet) VALUES ('manager4','HTZ123','123','manager',4);




--add jobs;
INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('2018-10-10','2018-5-10','jj334',NULL,NULL,NULL,'repair',NULL,2,NULL,1,2,0,NULL,NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('2018-10-10','1541035846','NZT123',NULL,NULL,NULL,'Engin broke',NULL,1,NULL,1,4,0,NULL,NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','HTZ123',NULL,NULL,NULL,'Rear door broke',NULL,1,NULL,2,9,0,NULL,NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U111',NULL,NULL,NULL,'Rear door broke',NULL,1,NULL,2,10,0,NULL,NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U111',NULL,NULL,NULL,'Rear door broke',NULL,1,NULL,2,11,0,NULL,NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U111',12,13,NULL,'Rear door broke',NULL,1,NULL,2,11,1,'2018-11-06',NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U111',12,13,NULL,'window broke',NULL,1,NULL,2,11,1,'2018-11-06',NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U444',12,13,NULL,'back window broke',NULL,1,NULL,2,15,1,'2018-11-06',NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U555',12,13,NULL,'back window broke',NULL,1,NULL,2,16,1,'2018-11-06',NULL);

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U666',12,13,14,'back seat broke',NULL,1,NULL,2,17,1,'2018-11-06','2018-11-06');

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U667',12,13,14,'back seat broke',NULL,1,NULL,2,18,1,'2018-11-06','2018-11-06');

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U668',12,13,14,'back seat broke',NULL,1,NULL,2,18,1,'2018-11-06','2018-11-06');

INSERT INTO jobs ( closedate, createdate, carNo, desk, manager, worker, jobDescription, resolve, priority, comment, outlet,customer,jobStatus,opendate,assigndate)
VALUES('','2018-11-06','U669',12,13,14,'back seat broke',NULL,1,NULL,2,16,1,'2018-11-06','2018-11-06');


      

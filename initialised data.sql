
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

      
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:03:46', '2018-11-09 00:25:23', 'TTT123', 99, 97, 103, 'teteresret', '1', '2', '', '1', '106', '2', '2018-11-09 00:25:09', '2018-11-09 00:26:35', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:03:46', '2018-11-09 00:25:23', 'AAA123', 99, 97, 103, 'teteresret', '1', '2', '', '1', '106', '2', '2018-11-09 00:25:09', '2018-11-09 00:26:35', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:03:46', '2018-11-09 00:25:23', 'bbb123', 99, 97, 103, 'teteresret', '1', '2', '', '1', '106', '2', '2018-11-09 00:25:09', '2018-11-09 00:26:35', '0', '');


INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory )
 VALUES ('2018-11-09 00:04:02', '2018-11-09 00:25:30', 'aaa001', 99, NULL, NULL,'3434343', 0, 1, '', 1, 106, 3, '2018-11-09 00:25:23', '2018-11-09 00:25:23', 0, '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory )
 VALUES ('2018-11-09 00:04:02', '2018-11-09 00:25:30', 'bbb001', 99, NULL, NULL, '3434343', '0', '1', '', '1', '106', '3', '2018-11-09 00:25:23', '2018-11-09 00:25:23', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory )
 VALUES ('2018-11-09 00:04:02', '2018-11-09 00:25:30', 'ccc001', 99, NULL, NULL, '3434343', '0', '1', '', '1', '106', '3', '2018-11-09 00:25:23', '2018-11-09 00:25:23', '0', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:05:42', '2018-11-09 00:05:57', 'eee34', NULL, NULL, NULL, '343433434', '1', '1', '', '1', '107', '0', '2018-11-09 00:05:52', '2018-11-09 00:05:52', '1', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:05:42', '2018-11-09 00:05:57', 'ddd34', NULL, NULL, NULL, '343433434', '1', '1', '', '1', '107', '0', '2018-11-09 00:05:52', '2018-11-09 00:05:52', '1', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:05:42', '2018-11-09 00:05:57', 'fff34', NULL, NULL, NULL, '343433434', '1', '1', '', '1', '107', '0', '2018-11-09 00:05:52', '2018-11-09 00:05:52', '1', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:59:42', '2018-11-09 00:59:56', '2345', 98, '97', '103', 'eeeeee', '1', '1', '', '1', '106', '2', '2018-11-09 00:59:42', '2018-11-09 01:12:47', '1', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:59:42', '2018-11-09 00:59:56', 'qqq2345', 98, '97', '103', 'eeeeee', '1', '1', '', '1', '106', '2', '2018-11-09 00:59:42', '2018-11-09 01:12:47', '1', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 00:59:42', '2018-11-09 00:59:56', 'www2345', 98, '97', '103', 'eeeeee', '1', '1', '', '1', '106', '2', '2018-11-09 00:59:42', '2018-11-09 01:12:47', '1', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:13:21', '2018-11-09 01:00:04', '4444', 98, '97', '102', '44444', '2', '1', '', '1', '109', '3', '2018-11-09 00:59:59', '2018-11-09 01:12:52', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:13:21', '2018-11-09 01:00:04', 'eee4444', 98, '97', '102', '44444', '2', '1', '', '1', '109', '3', '2018-11-09 00:59:59', '2018-11-09 01:12:52', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:13:21', '2018-11-09 01:00:04', 'tttt4444', 98, '97', '102', '44444', '2', '1', '', '1', '109', '3', '2018-11-09 00:59:59', '2018-11-09 01:12:52', '0', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:00:15', '2018-11-09 01:00:22', 'uuu343', 98, '97', NULL, '3434343', '1', '1', '', '1', '107', '1', '2018-11-09 01:00:15', '2018-11-09 01:00:15', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:00:15', '2018-11-09 01:00:22', 'iii343', 98, '97', NULL, '3434343', '1', '1', '', '1', '107', '1', '2018-11-09 01:00:15', '2018-11-09 01:00:15', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:00:15', '2018-11-09 01:00:22', 'ooo343', 98, '97', NULL, '3434343', '1', '1', '', '1', '107', '1', '2018-11-09 01:00:15', '2018-11-09 01:00:15', '0', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:36', '2018-11-09 01:01:45', '23232', 99, '97', NULL, '23232', '1', '1', '', '1', '110', '1', '2018-11-09 01:01:36', '2018-11-09 01:01:36', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:36', '2018-11-09 01:01:45', 'ert123', 99, '97', NULL, '23232', '1', '1', '', '1', '110', '1', '2018-11-09 01:01:36', '2018-11-09 01:01:36', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:36', '2018-11-09 01:01:45', 'tt232', 99, '97', NULL, '23232', '1', '1', '', '1', '110', '1', '2018-11-09 01:01:36', '2018-11-09 01:01:36', '0', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:54', '2018-11-09 01:02:01', 'yyy4545', 99, '97', NULL, '454545', '1', '1', '', '1', '106', '1', '2018-11-09 01:01:54', '2018-11-09 01:01:54', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:54', '2018-11-09 01:02:01', 'uuu545', 99, '97', NULL, '454545', '1', '1', '', '1', '106', '1', '2018-11-09 01:01:54', '2018-11-09 01:01:54', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:01:54', '2018-11-09 01:02:01', 'www545', 99, '97', NULL, '454545', '1', '1', '', '1', '106', '1', '2018-11-09 01:01:54', '2018-11-09 01:01:54', '0', '');

INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:06:27', '2018-11-09 01:06:32', 'uio3434', 98, '97', NULL, '34343', '1', '1', '', '1', '108', '1', '2018-11-09 01:06:27', '2018-11-09 01:06:27', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:06:27', '2018-11-09 01:06:32', 'pp3434', 98, '97', NULL, '34343', '1', '1', '', '1', '108', '1', '2018-11-09 01:06:27', '2018-11-09 01:06:27', '0', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:06:27', '2018-11-09 01:06:32', 'zzz3434', 98, '97', NULL, '34343', '1', '1', '', '1', '108', '1', '2018-11-09 01:06:27', '2018-11-09 01:06:27', '0', '');

INSERT INTO  jobs  ( closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:17:03', '2018-11-09 01:17:11', 'uuu43', NULL, NULL, NULL, '3434', '1', '1', '', '1', '110', '0', '2018-11-09 01:17:03', '2018-11-09 01:17:03', '1', '');
INSERT INTO  jobs  (  closedate ,  createdate ,  carNo ,  desk ,  manager ,  worker ,  jobDescription ,  resolve ,  priority ,  comment ,  outlet ,  customer ,  jobStatus ,  opendate ,  assigndate ,  jobType ,  jobHistory ) 
VALUES ('2018-11-09 01:17:03', '2018-11-09 01:17:11', 'ooo343', NULL, NULL, NULL, '3434', '1', '1', '', '1', '110', '0', '2018-11-09 01:17:03', '2018-11-09 01:17:03', '1', '');



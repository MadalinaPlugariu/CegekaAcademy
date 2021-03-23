


--EX2
DROP PROCEDURE IF EXISTS AddWorkload; 
GO
CREATE PROCEDURE AddWorkload (@id_Freelancer  INTEGER,
							 @workday        DATETIME,
							 @hours          FLOAT)
AS 
 BEGIN
       IF (@hours<=8)
 	    BEGIN
	     INSERT INTO dbo.workday
						(id_Freelancer,
						 workday,
						 hours)
	     VALUES         (@id_Freelancer,
						 @workday,
						 @hours)
	  END
	  ELSE
	   BEGIN
	    PRINT 'Give a value smaller or equal than 8 and try again.'
		return;
	  END
END


EXEC AddWorkload @id_Freelancer = 1, @workday='4/23/2017 12:00:00 AM', @hours=9;


SELECT * FROM dbo.workday WHERE id_Freelancer=1;




--EX3:

DROP PROCEDURE IF EXISTS CheckWorkload; 
GO
CREATE PROCEDURE CheckWorkload(@id  INTEGER)
AS 
 BEGIN
	  IF((SELECT COUNT(w.workday) from dbo.workday w join dbo.projects p on w.id_project=p.id  where p.id=@id group by w.id_project, p.id)<(SELECT [estimation(days)] from dbo.projects where id=@id))
	   BEGIN
	         PRINT N'Not enough workload'; 
	   END
	  ELSE 
	   BEGIN
	     PRINT N'Enough workload';
	   END  
  END


  EXEC CheckWorkload @id=2;



--EX4:

SELECT SUM(w.hours)*f.[price(hour)] FROM dbo.workday w join dbo.Freelancer f on w.id_Freelancer=f.id 
join dbo.projects p on w.id_project = p.id where p.id=2 and YEAR(w.workday)=2017 and MONTH(w.workday)=3
GROUP BY w.id_Freelancer, f.id, w.id_project, p.id, f.[price(hour)];
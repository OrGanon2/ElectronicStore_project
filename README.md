פרוייקט כספומט דיגיטלי : 



הפרוייקט הינו הדמיה של בנק וירטואלי  כאשר יש לך שם משתמש וסיסמא כדי להיכנס לחשבון שלך
ולנהל שם פעולות משתמש כגון משיכה , הפקדה העברה וכו' מפורט בהמשך בפונקציונאלייות הפרוייקט
יש אפשרות להרשמה עם ולידציה של אימייל
הפרוייקט מציג יכולות של ממשק משתמש מודרני במערכת שלא מאפשרת הרבה יכולות כמו windows forms
ניהול של מסד נתונים עם טבלאות היגיוניות וקשרים נכונים 

פונקציונאליות של הפרוייקט :

משתמש רגיל : 


	יכול לראות את העובר ושב שלו עם כל הפעולות שבוצעו מאז יצירת המשתמש					
	יכול למשוך כסף /להפקיד כסף.
	יכול לקחת הלוואה לשלם הלוואה ולראות את רשימת ההלואות הקיימות .
	יכול להעביר כסף לחשבון אחר שקיים במערכת.
	יכול ליצור חסכון חדש ,להפקיד אליו כסף , ולמשוך ממנו חלק מהסכום או את כולו ולראות את רשימת החסכונות הקיימים.
	יכול לבקש להוסיף כרטיס אשראי חדש , לבטל קיים  ולראות את רשימת הכרטיסים .
	יכול לערוך את הנתונים האישיים שלו כגון סיסמא כתובת אימייל ופלאפון.


אדמין : 

	בעיקרון הקו מחשבה שלי לפעולות של אדמין בפרוייקט הנל זה פשוט גישה יותר נוחה למסד נתונים  מהממשק משתמש
	אדמין יכול למחוק משתמש,
	למחוק כרטיסים למשתמשים
	לשנות את כל ההגדרות של החשבונות 
	כגון: בלאנס ,מספר חשבון , שם משתמש וסיסמא 
	אדמין יכול לראות רשימה של  כל הלקוחות הקיימים במערכת 
	אדמין יכול לרשום אימייל ללקוח מסויים או לכולם מהמערכת
	וכמובן שגם אדמין יכול לעשות את כל הפעולות של משתמש רגיל כי גם הוא משתמש של הבנק פשוט עם יוכולות יותר גבוהות 





דברים שהייתי רוצה להפנות אליהם את תשומת הלב בפרוייקט :

בפרוייקט הצגתי המון למידה עצמית והייתי רוצה לפרט את הדברים שעשיתי ואיפה יש תקלות שלא הספקתי לשפץ 



נתחיל בעבודה עם smtpClient :

חיפשתי באינטרנט איך בעצם שולחים מייל מסי שארפ ? ומצאתי את הבחור החמוד הזה והתחלתי לעבוד איתו ולעזור לחברי לכיתה לממש אותו , תאמת
שעם האימייל לא היו לי בבעיות.



עבודה עם קובץ פייתון חיצוני ,שורת התיפקוד וטויליו:(Twilio)


בפרוייקט מאוד הייתי רוצה שבהרשמה יהיה אופציה ללקוח לבחור איך לאמת את עצמו 
בפלאפון או באימייל 
אימייל כמובן הצלחתי אבל פלאפון הצלחתי חלקית 
אז ככה 
הצלחתי למצוא קוד של פייתון באינטרנט לשלוח הודעה בעזרת API של twilio 
עכשיו הבעיה שאני יכול לשלוח רק לעצמי את ההודעה כי צריך לשלם להם כסף
את הקוד של הפייתון הרצתי בעזרת פנייה לשורת הפקודה מקוד של סי שארפ המתודה מופיע בפרוייקט הלוגיק במחלקת הרשימת מתודות (MethodList)


אז לסיכום הקוד כן עובד אבל אי אפשר לממש אותו על אנשים אחרים
לא יודע אם אפשר להגדיר את זה כניצחון 

the method of sending sms called SendSms In the methodlist class 


אני מחליף לאנגלית כי לא זורם איתו הכתבן פה



Design Patterns:

In the project i was able to implement 3 Design Patterns : 

Number 1 : 
Single Tone ... in the MethodList class there is an singletone implementation 
Number 2 : 
Factory Method ... in the Models file There is alot of factory methods that create instances of the present models 
Number 3 : (save the best for last)
GenericRepository the one that i most proud of . 
in the DB Data accsess layer there is an implement of generic repository and unitofwork 
i implemented all of that on my models as you can see in the db DAL 


Final Notes (Please read this its important) : 

i couldn't change the modelss file name to models with 1 S . it wont change 

the admin username and password is : 
username : orshani8
password : orshani1

Feel free to register but just dont choose the phone validation option
becuase i use twilio api i cant send sms to other phone numbers than my phone 


Becuase i cant find any other feature to add i  will just add a 1 html & css page 
to show some other skills i have .
Hope you find this project Professional enough

ty for reading and have fun .
 

רוצה להודות למארק המתרגל שעזר לי עם repository patterns
בלעדיו לא הייתי מיישם את התבנית עיצוב הזאת 






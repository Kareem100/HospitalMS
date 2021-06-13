# Horas Management System (HMS)
Horas Management System is a Hospital Management System using C#, Windows Forms and Oracle Database. <br>

# Description
The HMS is organized into clinics. Each clinic has a name, working hours and floor number. We keep track of :
- **Medical Staff** (first and last name, age, gender, specialization, shifting time, year of employment, and contact number). The Medical Staff Includes [Doctors - Receptionists]
- **Patient** (National ID number, full name, conditional illness, responsible doctor, and the room he stayed at)
- **The current available Medicine** (code number, name, quantity, and price).

# Prerequisites
1. Install Visual Studio 
2. Install Crystal Reports with the same version of VS
3. Any Oracle Database.

# Getting into the project

<details>
  <summary>ERD</summary>
<p>
    
![ERD](https://user-images.githubusercontent.com/48657780/121788332-bbd50980-cbcc-11eb-94cf-6c6a0b282b88.png)

</p>
</details>
<details>
  <summary>Schema</summary>
<p>
  
 ![Schema](https://user-images.githubusercontent.com/48657780/121788243-17eb5e00-cbcc-11eb-85d4-7dc1b006daed.png)
  
</p>
</details>


🔸 [Database SQL Script](HospitalMS/Database/HMS_Database.sql) <br>
🔸 [Database Procedures](HospitalMS/Database/Procedures) 


’Login’ Page where the Doctors & Receptionists can login into their accounts. <br>

![Screenshot (180)](https://user-images.githubusercontent.com/48657780/121788826-d90bd700-cbd0-11eb-93b4-a2e3d6ed0778.png)

’Register’ Page allows Doctors & Receptionists to register and make an account, all fields have validation checkers. <br>

![Screenshot (182)](https://user-images.githubusercontent.com/48657780/121789016-8df2c380-cbd2-11eb-97e4-745eb7d551de.png)

**’Doctor Part’** consists of 4 pages: <br>
1. **Home**, where the doctor can show all the reports that he has made
2. **My Data**, where he can edit any thing related to his profile like the name, shift time or ...
3. **My Clinic**
4. **Add Report.**

![Screenshot (185)](https://user-images.githubusercontent.com/48657780/121789197-3ead9280-cbd4-11eb-9b5c-9d93e5781e83.png)

’Clinic’ Page, where the doctor can show the clinic name, working hours or display all the other clinics. 

![Screenshot (188)](https://user-images.githubusercontent.com/48657780/121789424-23438700-cbd6-11eb-9f0f-c4c05ea71976.png)

’Add Report’ Page, Each doctor writes a detailed Report for each patient describing the medicines which the patient took,
the duration patient spent and his conditional illness.

![Screenshot (191)](https://user-images.githubusercontent.com/48657780/121789512-d613e500-cbd6-11eb-9700-968b191e27cb.png)

**’Receptionist Part’** consists of 5 pages: <br>
1. **Home**, where the receptionist can show all the bills of the patients
2. **My Data**, where he can edit any thing related to his profile like the name, shift time or ...
3. **Make an Appointment**
4. **Make a Bill**
5. **Show Rooms.**

’Make an Appointment’ Page, where the receptionist can make an appointment between the doctor and the patient.

![Screenshot (196)](https://user-images.githubusercontent.com/48657780/121789825-9ac6e580-cbd9-11eb-9955-7fd87edca19f.png)

’Make a Bill’ Page, where the receptionist makes a bill contains the patient name, medicine and cost.

![Screenshot (199)](https://user-images.githubusercontent.com/48657780/121789882-1163e300-cbda-11eb-9185-9ba2fb19d788.png)

’Show Rooms’ Page, where the receptionist shows all the rooms. Each room has a unique number, floor number, number of all beds and taken beds.

![Screenshot (203)](https://user-images.githubusercontent.com/48657780/121789922-7ae3f180-cbda-11eb-97f4-ea3b99f8db9d.png)


# Other Screenshots 

<details>
  <summary>Reports</summary>
<p>
    
![](Screenshots/3.%20Reports/ReportForm.png)
![](Screenshots/3.%20Reports/DisplayReports.png)
  
</p>
</details>

<details>
  <summary>Bills</summary>
<p>

![](Screenshots/6.%20Bills/DisplayBillsForm.png)

</p>
</details>

  
<details>
  <summary>Pharmacy</summary>
<p>
    
![](Screenshots/7.%20Pharmacy/PharmacyForm.png)

</p>
</details>

<details>
  <summary>Medical Stuff Data</summary>
<p>
  
![](Screenshots/8.%20Stuff/UserDataForm.png)
  
</p>
</details>
  
  <details>
  <summary>Change Password</summary>
<p>
  
  ![](Screenshots/9.%20Password/ChangePasswordForm.png)
  
</p>
  </details>
  
  <details>
  <summary>Show Patients</summary>
<p>
  
  ![](Screenshots/10.%20Patients/PatientsForm.png)
  
</p>
  </details>

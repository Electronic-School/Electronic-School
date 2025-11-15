Add student, teacher, worker’s data
Retrieving the required data whenever, using the search specification.
Calculate the sum of student’s marks
Calculate the avg of the student’s marks
Sorting the students in a list depending on the (highest avg, ….)
Tracking the absence of the students
Tracking the absence of the teachers
Allow father to check his child level.

The electronic school is a system that all to automate the school system. So the data will

The administrator enter the student data( ID, name, date of birth, address, course, number of subject, parent ID), then the student is add to the database of the school. Create a new account for the student automatically in the system, so he will be able to see his information.
The administrator enter the teacher data (ID, name, date of birth, address, salary, education degree, getting date, teacher subject, start working date, number of vacations, phone number, email, social status), the data are save in the database, creating the account for the teacher to be able to check his data. Also the teacher will be able to see the courses that he is teaching, and all the students who enrolled in the course.

Interaction Flow for Users and Administrators with data base

User Action
The interaction begins when the user (or the administrator) performs an action on the interface, such as opening a page, submitting a form, or requesting to view certain information.

Interface Request
The user interface sends this request to the system’s internal controller, which is responsible for understanding what the user wants.

System Processing
The controller identifies the type of action requested.
It then asks the system’s data layer to handle the operation, whether it involves displaying information, adding new data, or making changes.

Communication with the Database
The data layer communicates with the database to perform the required operation.
The database receives the request, processes it, and prepares the appropriate response.

Receiving the Result
Once the database completes the operation, it returns the result to the system.
The system organizes this result into a clear format that the interface can display.

Displaying to the User
The interface presents the final information or confirmation message to the user.
This could be a list of items, details of a specific record, a confirmation that a change was saved, or a notification if something went wrong.

Administrator-Specific Interaction
When the action comes from an administrator, the process is the same, but the system first verifies that the administrator has the necessary permissions before allowing any management or modification actions.

Determining the Entities
schoolMangement
Student
Teacher
parent
fees
courses
curriculum
activities
employees

The attributes for each entity:
Student:
ID (pk)
Name (F, L)
DateOfBirth
age
Address
course
numberofsubject
ParentID
Management:
ManagerID (pk)
EmployeeID (fk) (linking to the teacher or employee table.
Title: (principal, or dean of students)
Responsibilities: a brief description of their duties.
StartDate: the date they began their management role.

Teacher
ID (pk)
Name (F, L)
DateOfBirth
Age (derived)
Address (country, city, street number, apartment)
Salary
EducationDegree
GettingDate
TeachingSubject
startWorkingDate
numberOfVacctions
phoneNumber
Email
SocialStatus

Parents:
They will primarily use the system to stay informed about their child’s academic standing and attendance.
ID (pk)
Name (F, L)
DateOfBirth
Age (derived)
Address
PhoneNumber
Email
ChildrenInSchool

Courses
Course is a specific, discrete unit of study that exists within the curriculum. It’s a subject taught over a defined period (semester or a year).
Is led by a specific instructor.
ID (pk)
Name
StartDate
EndDate
teacherID
curriculumID (fk)

Curriculum
defines the educational goals, content standards, and learning outcomes.
Answers the question: “What is the collective knowledge and skills students must acquire?”
ID (pk)
Name
Description

studentCourseEnrollment
studentID (pk, fk)
CourseID (pk, fk)
FinalGrade
Attendance
EnrollmentDate

Activities:
activityID (pk)
activityName
Description
Schedule
Location
SupervisorID (fk)

studentActivities:
studentID
activityID
JoinDate
Role (team captain, member)

Employees
EmployeeID (PK)
FirstName
LastName
DateOfBirth
Address
PhoneNumber
Email
JobTitle ("Administrative Assistant," "Librarian").
Department ("Human Resources," "Facilities").
HireDate: The date the employee started working.
Salary
Status ("Active," "On Leave," "Terminated").

Attendance:
To track the attendance of the student, teachers, employees
AttendenceID (pk)
PersonID (fk)
Date
Status (present, absent, late, excused)
CourseID (fk)

When searching about student, teacher, father
Use the ID
If student

Some policies and rules:
The user must be verified before allowing him login the system.
Each user has a unique identifier with strong password. E
Each student can see his personal information but can’t change them.
Father can see his child’s data too, using his own username and password.
Student in the first grade must be in age of 7.
Student must get higher than 70% to pass his current level.

Some procedures that the system will do:
Add student, teacher, worker’s data
Retrieving the required data whenever, using the search specification.
Calculate the sum of student’s marks
Calculate the avg of the student’s marks
Sorting the students in a list depending on the (highest avg, ….)
Tracking the absence of the students
Tracking the absence of the teachers
Allow father to check his child level.

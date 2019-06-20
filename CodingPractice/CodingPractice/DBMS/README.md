### DBMS
A database management system (DBMS) is system software for creating and managing databases. The DBMS provides users and programmers with a systematic way to create, retrieve, update and manage data.     
There are many types of database but will consider SQL and NOSQL database.

#### Difference between SQL and NOSQL

![alt text][sqlnosql]

[sqlnosql]: https://github.com/senthil338/coding_interview/blob/master/Images/SQLNOSQL.png "SQL vs NOSQL"

#### Below are some of the features of NoSQL:
**1.Flexibility:** NoSQL offers flexibility to store structured, semi-structured or unstructured data, unlike a relational database which allows only structured data.   

**2. Dynamic Schemas:** In NoSQL schema definition is not required, this solves the problem to modify the schema where a table is already present with huge datasets and new columns need to be added to the same table.   

**3.Sharding:** Sharding means partitioning data into smaller databases to have faster access to data. This feature is present in NoSQL databases which allow us to fetch data from a server in fastest time.   

**4.Generic:** NoSQL database can be customized by the user as per the need.   

**5.Scaling:** NoSQL databases scale out horizontally thus, they are cheaper to manage.   

#### What is the CAP theorem

**1.Consistency:** Data in the database must be consistent before and after the execution of any operation. For example, after an update operation, every user should see the same data.   

**2.Availability:** System should always be up and running, there should be no downtime.

**3.Partition Tolerance:** System should work even if the communication among the servers is unreliable.
Theoretically, it is not possible to achieve all three requirements. CAP theorem allows distributed systems to follow any two of these requirements. Since partition tolerance is mandatory for distributed databases. Thus, we are left only with CP (Consistency, Partition tolerance) and AP (availability, Partition tolerance).    
Some of the examples of AP systems are **Dynamo, Cassandra, Simple DB, CouchDB**
Some of the examples of CP systems are **Big Table, Hyper Table, Mongo DB, HBase**

#### What is BASE in NoSQL
The CAP theorem states that distributed systems cannot achieve all three properties at the same time; consistency, availability and partition tolerance. The BASE system gives up on consistency while maintaining the other two. The BASE system works well despite physical network partitions and always allow a client with reading and write availability.
BASE stands for:  
**B**asically **A**vailable   
**S**oft state   
**E**ventual consistency   

#### What are the different types of NoSQL databases
1.Document Database    
2.Column Database   
3. Key-Value stores   
4. Cache systems: These are similar to key-value pairs. They store frequently accessed data in memory for fast retrieval and access.   
5. Graph database   

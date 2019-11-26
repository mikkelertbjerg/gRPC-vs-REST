# gRPC vs. REST

## Abstract

## Introduction

## Hypothesis

## The experiment
To test our Hypothesis we will set up an experiment with Grpc and a Rest API.
These experiments has to adhere to the following.

**Rules**
* To ensure accurate measurements, the results must be obtained from the same computer.
* Multiple data structures should be tested.
* The setup for both Apis has to be as similar as possible.
* The time used for measuring should be obtained from the client.

**Set up**
* to adhere to the multiple data structures rule, there will be a database which will feed us, single instances of an object, and feed us multiple instances of an object which we can turn into a list.
* Each API will have 2 methods to call. 
    * one for a single instance which takes a parameter of Id.
    * one for a collection of instances, more specifically a 100 instances.
* Each API will be tested with a client written in C# as a console app.
    * Time will be measured with a .NET Stopwatch.
    * the stopwatch will begin when the method is called and end when the API returns the full data.
* To get an average time, each operation will be executed 100 times. this result with be the one we conclude on.

## REST

### _What is REST_
For this blog, we have decided to work with the common implementation of REST and not the full implementation of a RESTful API; the differences can be found in [this blog.](https://blog.ndepend.com/rest-vs-restful/)

The key features to take note of when using rest:
* **Separation of client and server** 
    * Which is to say that our server and client can be implemented independently without knowing each other and that we can change the code on the server or client without affecting the other seamlessly.
    The key here is that each end, knows the format of the methods available.

* **Statelessness**
    * Being stateless means that the server is not required to know the current state of the client and vice versa. Either end can understand any method calls, without knowing the previous called methods. You can read more about statelessness [here](https://restfulapi.net/statelessness/).
* **Invocation**
    * We invoke a method on the server via HTTP operations
    * GET - POST - PUT - DELETE
    * We believe them to be rather self explanatory but if you wanna read more about HTTP operations you can do so [here](https://www.restapitutorial.com/lessons/httpmethods.html)


## Setting up the experiment for the REST API

The architecture for this experiment is a simple one:
![](Arch.png)

The REST API exposes two endpoints, one for a single instance of an object and one for a collection of 100 instances of objects.

the objects are of the class ObjectModel and contains 2 properties:
* Id
* Str_value

all of this is saved in a database, hosted on a website belonging to a member of the experiment.

both of these endpoints will be called a 100 times, from the client from which we can measure the results.

The host computer is a **I7-9700k** which has 8 cores running 3.6/4.9 GHz


 



### Pros

### Cons

### Sample project and metrics
_Should include how to reproduce for yourself_

## gRPC

### Pros

### Cons

### Sample project and metrics
_Should include how to reproduce for yourself_

## possible errors

Both the client and server was running on the same computer, potentially competing for resources. To fix this we encourage people who seek to reproduce our results to host their APIs before testing them, we unfortunately didn't have the possibility/foresight at the time of testing.

## Conclusion
_Metrics comapred_
_When to gRPCS_
_When to REST_

## References

## Technology used

[Grpc](https://grpc.io/)

[.Net Web Api](https://dotnet.microsoft.com/apps/aspnet/apis)

[.Net console app](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2019)

[MySql Database](https://www.mysql.com/)

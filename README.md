# gRPC vs. REST

## Abstract

## Introduction

## Hypothesis

## REST

### What is REST
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

 



### Pros

### Cons

### Sample project and metrics
_Should include how to reproduce for yourself_

## gRPC

### Pros

### Cons

### Sample project and metrics
_Should include how to reproduce for yourself_

## Conclusion
_Metrics comapred_
_When to gRPCS_
_When to REST_

## References



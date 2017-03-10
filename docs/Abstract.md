# Squadron abstract

## Purpose

Main purpose of this tool is to provide easy way to create and manage your load testing scenarios.

Features :
- Simple DSL
- Run in most of OS and main Linux distros
- Make easy to run on most of major cloud providers

## Scenario example

For sake of simplicity, scenario description 
will be described in json format 

Standard configuration

```json
{    
    "url" : "http://localhost:9999/users",
    "verb" : "get",
    "headers" : {[
        "Accept": "application/json"
    ]} 
}
```

Advance configuration

```json
{
    "runner": {
        "interval" : "30s",
        "time": "2m",
        "clients": "5"
    },
    "url" : "http://localhost:9999/users",
    "verb" : "get",
    "headers" : {[
        "Accept": "application/json"
    ]} 
}
```
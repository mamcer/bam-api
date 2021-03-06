# Bamboo API

In `original` branch you will find the original source code for this application. In `master` an upgraded, refactored version.

> More details about why I published this project in [this blog post](https://mamcer.github.io/2018-09-02-i-cleaned-up-my-virtual-basement/)

## Description

This project was originally created in 2015. The main motivation was to collect different metrics from an Atlassian Bamboo continuous integration server. Metrics like: project quantity, plan quantity, average plan per project, average time to fix, etc.

It is composed by a simple desktop application that consume the Bamboo rest api to extract information. At application startup you are prompted to enter your Bamboo credentials. You must enter credentials of a user with administrator rights in order to see all the information. 

## Screenshots

![Screenshot 01](https://raw.githubusercontent.com/mamcer/bam-api/master/Doc/bamapi01.jpg)

![Screenshot 02](https://raw.githubusercontent.com/mamcer/bam-api/master/Doc/bamapi02.jpg)

## Quick API Reference

### Projects

	https://[bamboo-host]/rest/api/latest/project.json?expand=projects.project.plans.plan.stages&max-result=10

### Results

	https://[bamboo-host]/rest/api/latest/result.json?expand=results.result

### Queue

	https://[bamboo-host]/rest/api/latest/queue.json?expand=queuedBuilds

## Official Documentation

[https://developer.atlassian.com/bamboodev/rest-apis/using-the-bamboo-rest-apis](https://developer.atlassian.com/bamboodev/rest-apis/using-the-bamboo-rest-apis)

[https://developer.atlassian.com/bamboodev/rest-apis/bamboo-rest-resources](https://developer.atlassian.com/bamboodev/rest-apis/bamboo-rest-resources)

## Technologies

- Visual Studio 2013
- .NET Framework 4.0

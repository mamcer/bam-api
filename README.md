# Bamboo API

This project was originally created back in 2015. The motivation was to collect different metrics from an Atlassian Bamboo continuous integration server. Metrics like: Project quantity, plan quantity, average plan per project, average time to fix, etc.

It's composed by a simple desktop application that consume the Bamboo rest api to extract information. At application startup you are prompted to enter your Bamboo credential. You must enter credentials of a user with administrator rights in order to see all the information. 
## Screenshots

![Screenshot 01](https://raw.githubusercontent.com/mamcer/bam-api/original-version/Main/Doc/bamapi01.jpg)

![Screenshot 02](https://raw.githubusercontent.com/mamcer/bam-api/original-version/Main/Doc/bamapi02.jpg)

## Quick API Reference

### Projects

https://[bamboo-host]/rest/api/latest/project.json?expand=projects.project.plans.plan.stages&max-result=10

### Results

https://[bamboo-host]/rest/api/latest/result.json?expand=results.result

## Queue

https://[bamboo-host]/rest/api/latest/queue.json?expand=queuedBuilds

## Official Documentation

[https://developer.atlassian.com/bamboodev/rest-apis/using-the-bamboo-rest-apis](https://developer.atlassian.com/bamboodev/rest-apis/using-the-bamboo-rest-apis)

[https://developer.atlassian.com/bamboodev/rest-apis/bamboo-rest-resources](https://developer.atlassian.com/bamboodev/rest-apis/bamboo-rest-resources)
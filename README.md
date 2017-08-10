# Bamboo API

This project was originally created back in 2015. The motivation was to collect different metrics from an Atlassian Bamboo continuous integration server. Metrics like: Project quantity, plan quantity, average plan per project, average time to fix, etc.


## Reference

*Projects*

https://[bamboo-host]/rest/api/latest/project.json?expand=projects.project.plans.plan.stages&max-result=10

*Results*

https://[bamboo-host]/rest/api/latest/result.json?expand=results.result

*Queue*

https://[bamboo-host]/rest/api/latest/queue.json?expand=queuedBuilds

### Documentation

https://developer.atlassian.com/bamboodev/rest-apis/using-the-bamboo-rest-apis

https://developer.atlassian.com/bamboodev/rest-apis/bamboo-rest-resources

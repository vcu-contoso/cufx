# Introduction 
CUFX Version 4.5 Models Class Library. 

# Contents
-	schemas
    - CUFX-CUFX-4.5-resolved.yaml
        - [CUFX 4.5 SwaggerHub](https://app.swaggerhub.com/apis/CUFX/CUFX/4.5#/)
        - Export - Download API - YAML Resolved
-	packages
    - VyStar.ApiStandards.CUFX.Models.4.5.0-beta.1.nupkg
-	cufx-v4.5-server
    - Source code generated using Open API Generator

# Open API Generator

1. Start Docker.

2. Open Visual Studio Code working folder

    ```
    c:\temp
    ```

3. Copy the following schemas folder into working folder.

    ```
    c:\temp\schemas\CUFX-CUFX-4.5-resolved.yaml
    ```

4. Open the working folder in Integrated Terminal.

5. View all volumes:
	
	```
    docker volume ls
    ```

6. Create a volume:
	
	```
    docker volume create local
	```

7. Inspect the volume:

	```
    docker volume inspect local
    ```
	
8. Pull down the Open API Generator image:

	```
    docker pull openapitools/openapi-generator-cli
    ```
	
9. Run Open API Generator using CUFX-CUFX-4.5-resolved.yaml:

    ```
    docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate -i /local/schemas/CUFX-CUFX-4.5-resolved.yaml -g aspnetcore  -o /local/cufx-v4.5-server --additional-properties=aspnetCoreVersion=6.0,buildTarget=program,modelClassModifier=partial,nullableReferenceTypes=true,operationIsAsync=true,operationModifier=virtual,operationResultTask=true,packageName=VyStar.ApiStandards.CUFX,packageVersion=4.5.0,pocoModels=true,swashbuckleVersion=6.4.0,useFrameworkReference=true,useNewtonsoft=true,useSeparateModelProject=true,useSwashbuckle=true
    ```
If you want to learn more about using the code generator then refer to the following:
- [Open API Generator](https://openapi-generator.tech/)
    - [Getting Started](https://openapi-generator.tech/docs/installation)
    - [aspnetcore options](https://openapi-generator.tech/docs/generators/aspnetcore/)
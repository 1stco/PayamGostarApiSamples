<?php
    /**
     * Target: SavePerson
     *
     * Authors: Hossein Neshati, Omid Nasri
     * 
     * Description: A simple solution to store person in CRM.
     * 
     * Version: 1.0
     */
    try
    {
        // Enter the field with the username and password that has the necessary permission to store the person.
        $username = 'admin';
        $password = 'admin';
        // Replace <url> keyword to your CRM host address.
        $url = 'http(s)://<url>/services/api/IPerson.svc?wsdl';
        // Create new instance of SoapClient to call SavePerson method.
        $soapClient = new SoapClient( $url );
        $params = array(
            'username' => $username,
            'password' => $password,
            'person' => array(
                'CrmObjectTypeCode' => 'code1',
                'CrmObjectTypeIndex' => 24,
                'Categories' => array(
                    array(
                        'Key' => 'keyno'
                    )
                ),
                'IdentityType' => 'Person',
                'FirstName' => 'Hossein',
                'LastName' => 'Akbari'
            )
        );
        // Calling the SavePerson method.
        $result = $soapClient->SavePerson($params);
        // Checked that the operation was successful or not.
        if ($result->SavePersonResult->Success)
        {
            //Converting Object to JSON type then print output vlaue.
            echo json_encode($result, JSON_UNESCAPED_UNICODE);
        }
        else 
            echo $result->SavePersonResult->Message;
    }
    catch ( Exception $e ) 
    {
        // Print exception message
        echo $e->getMessage();
    }
?>
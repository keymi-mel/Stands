<?php

    $server="localhost";
    $user="root";
    $contra="";
    $db="trabajo";

    $miconexion= new mysqli($server, $user, $contra, $db);

    $name= $_GET['name'];
    $pss= $_GET['pss'];

    if(!$miconexion)
    {
        echo "error mi panaa";
    }
    else
    {
        $consulta= "select * from usuarios where name= '$name' AND pass = '$pss '";
        $resultado= mysqli_query($miconexion,$consulta);
        if(mysqli_num_rows($resultado)>0)
        {
            while($mostrar=mysqli_fetch_array($resultado))
            {
                echo $mostrar['mensaje'];                       
                     
            }
            
        }
        else
        {
            echo "surrender";
        }
    }

?>
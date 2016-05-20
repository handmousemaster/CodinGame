#!/bin/bash
# Read inputs from Standard Input.
# Write outputs to Standard Output.

read n

declare -a horsesArray

lower=0;

for((i=0 ; i<n ; i++)); do
    read Pi
    horsesArray[i]=$Pi
done

#IFS=$'\n' sorted=($(sort <<<"${horsesArray[*]}"))
sorted=( $( printf "%s\n" "${horsesArray[@]}" | sort -n ) )

previous=-1
min=9999

for i in "${sorted[@]}"
do
    if [[ $previous -ne -1 ]]; then 
        if [[ $min -gt $(($i-$previous)) ]]; then 
            min=$(($i-$previous))
        fi
    fi
    previous=$i
done

echo $min
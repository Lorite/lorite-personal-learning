#!/bin/bash

# Check if a file is provided
if [ $# -ne 1 ]; then
    echo "Usage: $0 <input_file>"
    exit 1
fi

input_file=$1
output_file="output.txt"

# Initialize variables
current_date=""

# Process the input file
while IFS= read -r line; do
    # Check if the line is a date
    if [[ $line =~ \[\[[0-9]{4}-[0-9]{2}-[0-9]{2}\]\] ]]; then
        current_date=$line
    # Check if the line is a number
    elif [[ $line =~ ^[0-9]+$ ]]; then
        continue
    # Process non-empty lines
    elif [[ -n $line ]]; then
        echo "- $line (on $current_date)" >> "$output_file"
    fi
done < "$input_file"

echo "Processing complete. Output written to $output_file."

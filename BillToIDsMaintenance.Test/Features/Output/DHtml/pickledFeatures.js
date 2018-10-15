jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "CR 131303 - Maintain BillToIDs Table.feature",
      "Feature": {
        "Name": "CR 131303 - Maintain BillToIDs Table",
        "Description": "IBM MSC Outbound Routing - create tool in Strategic EDI tool so that we can modify the table for CR 131302 at any time by adding and removing bill to IDs\r\nIn order to maintain BillToIDs table in UnitedStationers DB\r\nAs an operator\r\nI want to have a functionality to add or delete BillToID in BillToIDs table",
        "FeatureElements": [
          {
            "Name": "Get BillToIDs",
            "Slug": "get-billtoids",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "User does not provide any Keyword to search BillToID",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "It should return all the BillToIDs",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "Keyword",
                    "ExpectedRecords"
                  ],
                  "DataRows": [
                    [
                      "ABC",
                      "3",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "987",
                      "1",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "****",
                      "0",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Search BillToIDs",
            "Slug": "search-billtoids",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "There are the following records in BillToIDs table: ABC123, ABC456, ABC987 & Test",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "User use <Keyword> to search BillToID",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "It should return the <ExpectedRecords> records containing the keyword",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "BillToID"
                  ],
                  "DataRows": [
                    [
                      "987654",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "NewID",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Creat a New BillToID",
            "Slug": "creat-a-new-billtoid",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "User tries to create a <BillToID>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "There is no matched <BillToID> in DB",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "The <BillToID> should be created and stored in BillToIDs table",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "BillToID"
                  ],
                  "DataRows": [
                    [
                      "123456",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "ABCEDF",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Try to Create an existing BillToID",
            "Slug": "try-to-create-an-existing-billtoid",
            "Description": "",
            "Steps": [
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "User tries to create a <BillToID>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "There is a matched <BillToID> in DB",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "The <BillToID> should not be created and stored in BillToIDs table",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "BillToID"
                  ],
                  "DataRows": [
                    [
                      "123456",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ],
                    [
                      "ABCEDF",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Delete an existing BillToID",
            "Slug": "delete-an-existing-billtoid",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "There is an existing <BillToID> in BillToID table",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "User tries to delete <BillToID>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "<BillToID> should be deleted from BillToID table",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": [
          "@CR",
          "131303",
          "@BillToID",
          "@IBM",
          "MSC",
          "Outbound",
          "Routing"
        ]
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@CR",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "131303",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@BillToID",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@IBM",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "MSC",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "Outbound",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "Routing",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "CR 131303 - Maintain BillToIDs Table.feature",
        "Total": 5,
        "Passing": 5,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "CR 131303 - Maintain BillToIDs Table.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 5,
      "Passing": 5,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 1,
      "Passing": 1,
      "Failing": 0,
      "Inconclusive": 0
    }
  },
  "Configuration": {
    "SutName": "Maintain BillToID",
    "SutVersion": "1.0.0.0",
    "GeneratedOn": "15 October 2018 10:26:08"
  }
});
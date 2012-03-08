// DefinitionOfCWordInfo.h  
// ����������� ������ CWordInfo 
#pragma once

// ��������� ��� ���� ControllerID �������� ��������  
typedef struct {      
		char* type;       
		char* original;   
		int ID;
} CCtrlID;   

class CWordInfo {
public:
	// ����������� � ����������
	CWordInfo(int =-1, int =-1, int =-1, char * = "", char * ="",
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		int =-1, char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="",
		char * ="", char * ="", int =-1, char * ="", CCtrlID * =0);           
	// ����������� �����
	CWordInfo(const CWordInfo &); 
	
	// ����������
	~CWordInfo(); 
	
	// ������������
	const CWordInfo& operator=(const CWordInfo &); 
	
	// �������� ���������
	int operator==(const CWordInfo &) const; 

	// �������� �����������
	int operator!=(const CWordInfo &) const; 

	void setID (int );
	int getID () const;
	
	void setParentID (int );
	int getParentID () const;

	void setPosition (int );
	int getPosition () const;

	void setNumber (int );
	int getNumber () const;
	
	void setNumericValue (int );
	int getNumericValue () const;
	
	void setOriginal(char *);
	char* getOriginal() const;
	
	void setNF(char *);
	char* getNF() const;
	
	void setAlphabet(char *);
	char* getAlphabet() const;
	
	void setWordCase(char *);
	char* getWordCase() const;
	
	void setPos(char *);
	char* getPos() const;
	
	void setSyntacticFunction(char *);
	char* getSyntacticFunction() const;
	
	void setSurfaceSlot(char *);
	char* getSurfaceSlot() const;
	
	void setExtendedLexicalClass(char *);
	char* getExtendedLexicalClass() const;
	
	void setStem(char *);
	char* getStem() const;
	
	void setPunctuators(char *);
	char* getPunctuators() const;

	void setPerson(char *);
	char* getPerson() const;

    void setCase(char *);
	char* getCase() const;

	void setAnimateness(char *);
	char* getAnimateness() const;
	
	void setGender(char *);
	char* getGender() const;
	
	void setNounType(char *);
	char* getNounType() const;
	
	void setTense(char *);
	char* getTense() const;
	
	void setMood(char *);
	char* getMood() const;
	
	void setVoice(char *);
	char* getVoice() const;
	
	void setVerbTransitivity(char *);
	char* getVerbTransitivity() const;
	
	void setVerbForm(char *);
	char* getVerbForm() const;
	
	void setObjectLocalization(char *);
	char* getObjectLocalization() const;
	
	void setSemanticRelation(char *);
	char* getSemanticRelation() const;
	
	void setPolarityAndDirection(char *);
	char* getPolarityAndDirection() const;
	
	void setInchoative(char *);
	char* getInchoative() const;
	
	void setIsConjuctedWith(char *);
	char* getIsConjuctedWith() const;
	
	void setDegreeOfComparison(char *);
	char* getDegreeOfComparison() const;
	
	void setChildOfCollocation(char *);
	char* getChildOfCollocation() const;

	void setRootOfCollocation(char *);
	char* getRootOfCollocation() const;

	void setEmotionality(char *);
	char* getEmotionality() const;

	void setControllerID (CCtrlID* );
    CCtrlID* getControllerID() const ;

private:
	int ID;						// ��� "ID" : (���. � ����)������������� �����, ���������� � ������ ������, ������������� ��� ����� ���� ����� ��������� ������;
	int ParentID;				// ��� "ParentID": �������������� �������������� �����;
	int Position;				// ��� "Position" : ������� � �����������;
	char* Original;				// ��� "Original": ���� �����,� ����� � ������� ��� ������������ � �����������;
	char* NF;					// ��� "NF": normal form of word;
    char* Alphabet;				// ��� "Alphabet": ������������ �������;
    char* WordCase;				// ��� "WordCase": �����(���������, �������� ��� ����������) ������������ �����;
	char* Pos;			  		// ��� "Pos" : ����� ����� ����;
    char* SyntacticFunction;	// ��� "SyntacticFunction": ������� � �����������;
    char* SurfaceSlot;			// ��� "SurfaceSlot": ����� ���� �� ����������
    char* ExtendedLexicalClass; // ��� "ExtendedLexicalClass" �������� ������ ����� � ������� ����������� ����� �� �������� � ��������;
	char* Stem;					// ��� "Stem" ������ �����;
	char* Punctuators;			// ��� "Punctuators" : ����� ��� �������; 
	char* Person;				// ��� "Person" : ����;
    char* Case;                 // ��� "Case": �����;
    int   Number;               // ��� "Number": �����;
	char* Animateness;			// ��� "Animateness" : ������������ ��� �� ������������;
	char* Gender;				// ��� "Gender" : ���;
	char* NounType;				// ��� "NounType" : ��� ����������������;
	char* Tense;				// ��� "Tense": �����;
	char* Mood;					// ��� "Mood" : ����������;
	char* Voice;				// ��� "Voice" : �����;
	char* VerbTransitivity;		// ��� "VerbTransitivity" ��������������;
	char* VerbForm;				// ��� "VerbForm" : ����������� ��� �������������;
	char* ObjectLocalization;   // ��� "ObjectLocalization" : Inside, Outside;
    char* SemanticRelation;		// ��� "SemanticRelation" �����, ��, ���, �� ����/������;
	char* PolarityAndDirection;	// ��� "PolarityAndDirection" Agentive;
	char* Inchoative;			// ��� "Inchoative" ������������� true;
	char* IsConjuctedWith;	    // ��� "IsConjuctedWith" �������������� ����� ���������� � ���� ������;
	char* DegreeOfComparison;	// ��� "DegreeOfComparison" Positive; 
	char* ChildOfCollocation;	// ��� "ChildOfCollocation" Positive;
    char* RootOfCollocation;	// ��� "RootOfCollocation" true;
    int   NumericValue;			// ��� "NumericValue" ��������� ��������;
	char* Emotionality;			// ��� "Emotionality" �������������;
	CCtrlID* ControllerID;		// ��� "ControllerID", ����� ��� �������� type of reference� � original=ID ����� ���������� � ����; 	
};






















































































	
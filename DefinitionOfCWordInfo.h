// DefinitionOfCWordInfo.h  
// Определение класса CWordInfo 
#pragma once

// структура для тега ControllerID имеещего атрибуты  
typedef struct {      
		char* type;       
		char* original;   
		int ID;
} CCtrlID;   

class CWordInfo {
public:
	// конструктор с умолчанием
	CWordInfo(int =-1, int =-1, int =-1, char * = "", char * ="",
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		int =-1, char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="", 
		char * ="", char * ="", char * ="", char * ="", char * ="",
		char * ="", char * ="", int =-1, char * ="", CCtrlID * =0);           
	// конструктор копии
	CWordInfo(const CWordInfo &); 
	
	// деструктор
	~CWordInfo(); 
	
	// присваивание
	const CWordInfo& operator=(const CWordInfo &); 
	
	// проверка равенства
	int operator==(const CWordInfo &) const; 

	// проверка неравенства
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
	int ID;						// Тег "ID" : (нач. с нуля)индетификатор слова, уникальный в полном тексте, присваивается так чтобы было проще построить дерево;
	int ParentID;				// Тег "ParentID": индентификатор родительського слова;
	int Position;				// Тег "Position" : Позиция в предложении;
	char* Original;				// Тег "Original": само слово,в форме в которой оно употребленно в предложении;
	char* NF;					// Тег "NF": normal form of word;
    char* Alphabet;				// Тег "Alphabet": используемый алфавит;
    char* WordCase;				// Тег "WordCase": какие(заглавные, строчные или вперемешку) используются буквы;
	char* Pos;			  		// Тег "Pos" : какая часть речи;
    char* SyntacticFunction;	// Тег "SyntacticFunction": функция в предложении;
    char* SurfaceSlot;			// Тег "SurfaceSlot": часть речи на английском
    char* ExtendedLexicalClass; // Тег "ExtendedLexicalClass" содержит список групп к которым пренадлежит слово от меньшего к большему;
	char* Stem;					// Тег "Stem" основа слова;
	char* Punctuators;			// Тег "Punctuators" : точка или запятая; 
	char* Person;				// Тег "Person" : лицо;
    char* Case;                 // Тег "Case": падеж;
    int   Number;               // Тег "Number": число;
	char* Animateness;			// Тег "Animateness" : одушевленное или не одушевленное;
	char* Gender;				// Тег "Gender" : род;
	char* NounType;				// Тег "NounType" : тип существительного;
	char* Tense;				// Тег "Tense": время;
	char* Mood;					// Тег "Mood" : наклонение;
	char* Voice;				// Тег "Voice" : залог;
	char* VerbTransitivity;		// Тег "VerbTransitivity" транзитивность;
	char* VerbForm;				// Тег "VerbForm" : совершенный или несовершенный;
	char* ObjectLocalization;   // Тег "ObjectLocalization" : Inside, Outside;
    char* SemanticRelation;		// Тег "SemanticRelation" Время, ОБ, ЛОК, ОБ СОЗД/РАЗРУШ;
	char* PolarityAndDirection;	// Тег "PolarityAndDirection" Agentive;
	char* Inchoative;			// Тег "Inchoative" начинательный true;
	char* IsConjuctedWith;	    // Тег "IsConjuctedWith" индентификатор слова связанного с этим словом;
	char* DegreeOfComparison;	// Тег "DegreeOfComparison" Positive; 
	char* ChildOfCollocation;	// Тег "ChildOfCollocation" Positive;
    char* RootOfCollocation;	// Тег "RootOfCollocation" true;
    int   NumericValue;			// Тег "NumericValue" численное значение;
	char* Emotionality;			// Тег "Emotionality" Агрессивность;
	CCtrlID* ControllerID;		// Тег "ControllerID", имеет два атрибута type of referenceи и original=ID слова связанного с этим; 	
};






















































































	